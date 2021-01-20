using LiveCharts;
using LiveCharts.Configurations;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Graphomaniac
{
    public partial class MainForm : Form
    {
        static SerialPort serialPort;
        readonly List<ChartValues<MeasureModel>> values;

        bool pause = false;
        
        double[] min = new[] { 0d, 0d, 0d, 0d, 0d };
        double[] max = new[] { 0d, 0d, 0d, 0d, 0d };
        double[] avg = new[] { 0d, 0d, 0d, 0d, 0d };

        public MainForm()
        {
            InitializeComponent();
            UpdateCOMPortsList();
            UpdateParityList();
            connOptsDataBitsDropdown.SelectedIndex = 3;
            connOptsStopBitsDropdown.SelectedIndex = 0;
            serialPort = new SerialPort();

            var mapper = Mappers.Xy<MeasureModel>()
                .X(model => model.DateTime.Ticks)
                .Y(model => model.Value);

            Charting.For<MeasureModel>(mapper);

            values = new List<ChartValues<MeasureModel>>();
            chart.Series = new SeriesCollection();
            for (int i = 0; i < 5; i++)
            {
                var chartValues = new ChartValues<MeasureModel>();
                values.Add(chartValues);

                var series = new LineSeries
                {
                    Values = values[i],
                    PointGeometrySize = 0,
                    StrokeThickness = 1,
                    LineSmoothness = 0,
                    Fill = System.Windows.Media.Brushes.Transparent
                };

                chart.Series.Add(series);
            }

            chart.AxisX.Add(new Axis
            {
                DisableAnimations = true,
                //LabelFormatter = value => DateTime.Now.ToString("mm:ss"),
                LabelFormatter = value => "",
                Separator = new Separator
                {
                    Step = TimeSpan.FromSeconds(1).Ticks
                }
            });

            chart.DisableAnimations = true;
            chart.Zoom = ZoomingOptions.X;
            chart.Pan = PanningOptions.X;
            chart.Hoverable = false;
            chart.DataTooltip = null;


            chart2.DisableAnimations = true;
            chart2.AnimationsSpeed = TimeSpan.FromMilliseconds(100);
            chart2.Hoverable = false;
            chart2.DataTooltip = null;

            chart2.Series = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "",
                    Values = new ChartValues<double> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }
                }
            };


            chart2.AxisY.Add(
            new Axis
            {
                MinValue = 0
            });
        }

        private void UpdateCOMPortsList()
        {
            connOptsPortsComboBox.Items.Clear();
            foreach (string port in SerialPort.GetPortNames())
            {
                connOptsPortsComboBox.Items.Add(port);
            }
        }

        private void UpdateParityList()
        {
            connOptsParityDropdown.Items.Clear();

            foreach (string parity in Enum.GetNames(typeof(Parity)))
            {
                connOptsParityDropdown.Items.Add(parity);
            }

            connOptsParityDropdown.SelectedIndex = 0;
        }

        private void Connect()
        {
            serialPort.PortName = connOptsPortsComboBox.Text;
            serialPort.BaudRate = Int32.Parse(connOptsBaudDropdown.SelectedItem.ToString());
            serialPort.Parity = (Parity)Enum.Parse(typeof(Parity), connOptsParityDropdown.SelectedItem.ToString(), true);
            serialPort.DataBits = Int32.Parse(connOptsDataBitsDropdown.SelectedItem.ToString());
            serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), connOptsStopBitsDropdown.SelectedItem.ToString(), true);
            serialPort.DataReceived += SerialPortRX;
            serialPort.Open();
        }

        private void SerialPortRX(object sender, SerialDataReceivedEventArgs e)
        {
            Application.DoEvents();

            if (pause) return;

            var port = (SerialPort)sender;
            int bufferSize = port.BytesToRead;

            byte[] data = new byte[bufferSize];
            int bytes = port.Read(data, 0, bufferSize);

            if (bytes == 0) return;

            this.BeginInvoke((Action)(() =>
            {
                if (textBox1.Lines.Count() > 5000)
                    textBox1.ResetText();

                string text = Encoding.Default.GetString(data);

                string textToBox = text.Replace("\n", Environment.NewLine);
                textBox1.AppendText(textToBox);

                string[] variables = text.Split('\n')[0].Split(',');

                var now = DateTime.Now;

                int overhead = 0;
                try
                {
                    overhead = Convert.ToInt32(zoomTextBox.Text);
                }
                catch { }


                int zeroCount = 0;
                for (int i = 0; i < variables.Count(); i++)
                {
                    if (i >= 5) continue;

                    double dvar;
                    try
                    {
                        dvar = Convert.ToDouble(variables[i]);
                    }
                    catch
                    {
                        dvar = 0;
                    }
                    if (dvar == 0) zeroCount++;


                    var svalues = chart.Series[i].Values;

                    svalues.Add(new MeasureModel
                    {
                        DateTime = now,
                        Value = dvar
                    });

                    if (svalues.Count > overhead)
                    {
                        int diff = svalues.Count - overhead;
                        for (int j = 0; j < diff; j++)
                        {
                            svalues.RemoveAt(0);
                        }
                    }

                    chart2.Series[0].Values[i] = dvar;

                    if (dvar < min[i]) min[i] = dvar;
                    if (dvar > max[i]) max[i] = dvar;

                    avg[i] = 0.2 * dvar + (1 - 0.2) * avg[i];

                    var minLabel = this.Controls.Find("minLabel" + (i + 1).ToString(), true).FirstOrDefault() as Label;
                    minLabel.Text = min[i].ToString();
                    var maxLabel = this.Controls.Find("maxLabel" + (i + 1).ToString(), true).FirstOrDefault() as Label;
                    maxLabel.Text = max[i].ToString();
                    var emaLabel = this.Controls.Find("emaLabel" + (i + 1).ToString(), true).FirstOrDefault() as Label;
                    emaLabel.Text = Math.Round(avg[i], 2).ToString();
                }

                if (zeroCount == variables.Count())
                {
                    if (chart2.AxisY.Count == 0)
                    {
                        chart2.AxisY.Add(
                        new Axis
                        {
                            MinValue = 0
                        });
                    }

                    chart2.AxisY[0].MinValue = 0;
                }
                else
                {
                    if (chart2.AxisY.Count > 0)
                        chart2.AxisY.RemoveAt(0);
                }

                for (int i = variables.Count(); i < chart.Series.Count(); i++)
                {
                    var svalues = chart.Series[i].Values;

                    svalues.Add(new MeasureModel
                    {
                        DateTime = now,
                        Value = 0
                    });

                    if (svalues.Count > overhead)
                    {
                        int diff = svalues.Count - overhead;
                        for (int j = 0; j < diff; j++)
                        {
                            svalues.RemoveAt(0);
                        }
                    }
                }
            }));
        }

        private void ResetPanAndZoom()
        {
            chart.AxisX[0].MinValue = double.NaN;
            chart.AxisX[0].MaxValue = double.NaN;
            chart.AxisY[0].MinValue = double.NaN;
            chart.AxisY[0].MaxValue = double.NaN;
        }

        private void ComPortsReloadBtn_Click(object sender, EventArgs e)
        {
            UpdateCOMPortsList();
        }

        private void ComPortsBaudDropdown_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComPortsConnectBtn_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                Connect();
                comPortsConnectBtn.Text = "Disconnect";
            }
            else
            {
                serialPort.Close();
                comPortsConnectBtn.Text = "Connect";
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void ResetPanAndZoomBtn_Click(object sender, EventArgs e)
        {
            ResetPanAndZoom();
        }

        private void PauseBtn_Click(object sender, EventArgs e)
        {
            pause = !pause;

            if (pause)
            {
                pauseBtn.Text = "Resume";
            }
            else
            {
                pauseBtn.Text = "Pause";
                ResetPanAndZoom();
            }

        }

        private void resetStatsBtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                min[i] = 0;
                max[i] = 0;
                avg[i] = 0;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort.Close();
        }

        private void animateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            chart2.DisableAnimations = !animateCheckBox.Checked;
        }
    }

    public class MeasureModel
    {
        public System.DateTime DateTime { get; set; }
        public double Value { get; set; }
    }
}
