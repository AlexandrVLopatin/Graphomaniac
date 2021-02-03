
namespace Graphomaniac
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chart = new LiveCharts.WinForms.CartesianChart();
            this.zoomTextBox = new System.Windows.Forms.TextBox();
            this.resetZoomAndPanBtn = new System.Windows.Forms.Button();
            this.pauseBtn = new System.Windows.Forms.Button();
            this.spanLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connOptsStopBitsDropdown = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.connOptsDataBitsDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connOptsParityDropdown = new System.Windows.Forms.ComboBox();
            this.comsPortsParityLabel = new System.Windows.Forms.Label();
            this.connOptsBaudDropdown = new System.Windows.Forms.ComboBox();
            this.comPortsBaudLabel = new System.Windows.Forms.Label();
            this.comPortsConnectBtn = new System.Windows.Forms.Button();
            this.comPortsReloadBtn = new System.Windows.Forms.Button();
            this.connOptsPortsComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chart2 = new LiveCharts.WinForms.CartesianChart();
            this.animateCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minLabel1 = new System.Windows.Forms.Label();
            this.maxLabel1 = new System.Windows.Forms.Label();
            this.emaLabel1 = new System.Windows.Forms.Label();
            this.resetStatsBtn = new System.Windows.Forms.Button();
            this.emaLabel2 = new System.Windows.Forms.Label();
            this.maxLabel2 = new System.Windows.Forms.Label();
            this.minLabel2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.emaLabel3 = new System.Windows.Forms.Label();
            this.maxLabel3 = new System.Windows.Forms.Label();
            this.minLabel3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.emaLabel4 = new System.Windows.Forms.Label();
            this.maxLabel4 = new System.Windows.Forms.Label();
            this.minLabel4 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.emaLabel5 = new System.Windows.Forms.Label();
            this.maxLabel5 = new System.Windows.Forms.Label();
            this.minLabel5 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minValueTextBox = new System.Windows.Forms.TextBox();
            this.setMinValueBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(690, 58);
            this.textBox1.MaximumSize = new System.Drawing.Size(2048, 150);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(551, 85);
            this.textBox1.TabIndex = 8;
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(16, 169);
            this.chart.MaximumSize = new System.Drawing.Size(2048, 1000);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(647, 458);
            this.chart.TabIndex = 9;
            this.chart.Text = "cartesianChart1";
            // 
            // zoomTextBox
            // 
            this.zoomTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.zoomTextBox.Location = new System.Drawing.Point(84, 648);
            this.zoomTextBox.Name = "zoomTextBox";
            this.zoomTextBox.Size = new System.Drawing.Size(56, 20);
            this.zoomTextBox.TabIndex = 10;
            this.zoomTextBox.Text = "100";
            this.zoomTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComPortsBaudDropdown_KeyPress);
            // 
            // resetZoomAndPanBtn
            // 
            this.resetZoomAndPanBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetZoomAndPanBtn.Location = new System.Drawing.Point(146, 647);
            this.resetZoomAndPanBtn.Name = "resetZoomAndPanBtn";
            this.resetZoomAndPanBtn.Size = new System.Drawing.Size(119, 23);
            this.resetZoomAndPanBtn.TabIndex = 11;
            this.resetZoomAndPanBtn.Text = "Reset Zoom and Pan";
            this.resetZoomAndPanBtn.UseVisualStyleBackColor = true;
            this.resetZoomAndPanBtn.Click += new System.EventHandler(this.ResetPanAndZoomBtn_Click);
            // 
            // pauseBtn
            // 
            this.pauseBtn.Location = new System.Drawing.Point(755, 9);
            this.pauseBtn.Name = "pauseBtn";
            this.pauseBtn.Size = new System.Drawing.Size(75, 23);
            this.pauseBtn.TabIndex = 12;
            this.pauseBtn.Text = "Pause";
            this.pauseBtn.UseVisualStyleBackColor = true;
            this.pauseBtn.Click += new System.EventHandler(this.PauseBtn_Click);
            // 
            // spanLabel
            // 
            this.spanLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.spanLabel.AutoSize = true;
            this.spanLabel.Location = new System.Drawing.Point(43, 651);
            this.spanLabel.Name = "spanLabel";
            this.spanLabel.Size = new System.Drawing.Size(35, 13);
            this.spanLabel.TabIndex = 13;
            this.spanLabel.Text = "Span:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.connOptsStopBitsDropdown);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.connOptsDataBitsDropdown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pauseBtn);
            this.panel1.Controls.Add(this.connOptsParityDropdown);
            this.panel1.Controls.Add(this.comsPortsParityLabel);
            this.panel1.Controls.Add(this.connOptsBaudDropdown);
            this.panel1.Controls.Add(this.comPortsBaudLabel);
            this.panel1.Controls.Add(this.comPortsConnectBtn);
            this.panel1.Controls.Add(this.comPortsReloadBtn);
            this.panel1.Controls.Add(this.connOptsPortsComboBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1229, 40);
            this.panel1.TabIndex = 18;
            // 
            // connOptsStopBitsDropdown
            // 
            this.connOptsStopBitsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connOptsStopBitsDropdown.FormattingEnabled = true;
            this.connOptsStopBitsDropdown.Items.AddRange(new object[] {
            "1",
            "2"});
            this.connOptsStopBitsDropdown.Location = new System.Drawing.Point(587, 9);
            this.connOptsStopBitsDropdown.Name = "connOptsStopBitsDropdown";
            this.connOptsStopBitsDropdown.Size = new System.Drawing.Size(63, 21);
            this.connOptsStopBitsDropdown.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(531, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "StopBits:";
            // 
            // connOptsDataBitsDropdown
            // 
            this.connOptsDataBitsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connOptsDataBitsDropdown.FormattingEnabled = true;
            this.connOptsDataBitsDropdown.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.connOptsDataBitsDropdown.Location = new System.Drawing.Point(458, 9);
            this.connOptsDataBitsDropdown.Name = "connOptsDataBitsDropdown";
            this.connOptsDataBitsDropdown.Size = new System.Drawing.Size(63, 21);
            this.connOptsDataBitsDropdown.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "DataBits:";
            // 
            // connOptsParityDropdown
            // 
            this.connOptsParityDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.connOptsParityDropdown.FormattingEnabled = true;
            this.connOptsParityDropdown.Location = new System.Drawing.Point(330, 9);
            this.connOptsParityDropdown.Name = "connOptsParityDropdown";
            this.connOptsParityDropdown.Size = new System.Drawing.Size(63, 21);
            this.connOptsParityDropdown.TabIndex = 25;
            // 
            // comsPortsParityLabel
            // 
            this.comsPortsParityLabel.AutoSize = true;
            this.comsPortsParityLabel.Location = new System.Drawing.Point(290, 12);
            this.comsPortsParityLabel.Name = "comsPortsParityLabel";
            this.comsPortsParityLabel.Size = new System.Drawing.Size(36, 13);
            this.comsPortsParityLabel.TabIndex = 24;
            this.comsPortsParityLabel.Text = "Parity:";
            // 
            // connOptsBaudDropdown
            // 
            this.connOptsBaudDropdown.FormattingEnabled = true;
            this.connOptsBaudDropdown.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "128000",
            "153600",
            "230400",
            "256000",
            "460800",
            "921600"});
            this.connOptsBaudDropdown.Location = new System.Drawing.Point(220, 9);
            this.connOptsBaudDropdown.Name = "connOptsBaudDropdown";
            this.connOptsBaudDropdown.Size = new System.Drawing.Size(63, 21);
            this.connOptsBaudDropdown.TabIndex = 23;
            this.connOptsBaudDropdown.Text = "115200";
            this.connOptsBaudDropdown.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComPortsBaudDropdown_KeyPress);
            // 
            // comPortsBaudLabel
            // 
            this.comPortsBaudLabel.AutoSize = true;
            this.comPortsBaudLabel.Location = new System.Drawing.Point(182, 12);
            this.comPortsBaudLabel.Name = "comPortsBaudLabel";
            this.comPortsBaudLabel.Size = new System.Drawing.Size(35, 13);
            this.comPortsBaudLabel.TabIndex = 22;
            this.comPortsBaudLabel.Text = "Baud:";
            // 
            // comPortsConnectBtn
            // 
            this.comPortsConnectBtn.Location = new System.Drawing.Point(674, 9);
            this.comPortsConnectBtn.Name = "comPortsConnectBtn";
            this.comPortsConnectBtn.Size = new System.Drawing.Size(75, 23);
            this.comPortsConnectBtn.TabIndex = 21;
            this.comPortsConnectBtn.Text = "Connect";
            this.comPortsConnectBtn.UseVisualStyleBackColor = true;
            this.comPortsConnectBtn.Click += new System.EventHandler(this.ComPortsConnectBtn_Click);
            // 
            // comPortsReloadBtn
            // 
            this.comPortsReloadBtn.Location = new System.Drawing.Point(152, 8);
            this.comPortsReloadBtn.Name = "comPortsReloadBtn";
            this.comPortsReloadBtn.Size = new System.Drawing.Size(24, 23);
            this.comPortsReloadBtn.TabIndex = 20;
            this.comPortsReloadBtn.Text = "R";
            this.comPortsReloadBtn.UseVisualStyleBackColor = true;
            // 
            // connOptsPortsComboBox
            // 
            this.connOptsPortsComboBox.FormattingEnabled = true;
            this.connOptsPortsComboBox.Location = new System.Drawing.Point(72, 9);
            this.connOptsPortsComboBox.Name = "connOptsPortsComboBox";
            this.connOptsPortsComboBox.Size = new System.Drawing.Size(74, 21);
            this.connOptsPortsComboBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "COM Port:";
            // 
            // chart2
            // 
            this.chart2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.chart2.Location = new System.Drawing.Point(690, 160);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(554, 444);
            this.chart2.TabIndex = 19;
            this.chart2.Text = "cartesianChart1";
            // 
            // animateCheckBox
            // 
            this.animateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.animateCheckBox.AutoSize = true;
            this.animateCheckBox.Location = new System.Drawing.Point(716, 647);
            this.animateCheckBox.Name = "animateCheckBox";
            this.animateCheckBox.Size = new System.Drawing.Size(64, 17);
            this.animateCheckBox.TabIndex = 20;
            this.animateCheckBox.Text = "Animate";
            this.animateCheckBox.UseVisualStyleBackColor = true;
            this.animateCheckBox.CheckedChanged += new System.EventHandler(this.animateCheckBox_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "MIN:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "MAX:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "EMA:";
            // 
            // minLabel1
            // 
            this.minLabel1.AutoSize = true;
            this.minLabel1.Location = new System.Drawing.Point(49, 68);
            this.minLabel1.Name = "minLabel1";
            this.minLabel1.Size = new System.Drawing.Size(13, 13);
            this.minLabel1.TabIndex = 24;
            this.minLabel1.Text = "0";
            // 
            // maxLabel1
            // 
            this.maxLabel1.AutoSize = true;
            this.maxLabel1.Location = new System.Drawing.Point(49, 90);
            this.maxLabel1.Name = "maxLabel1";
            this.maxLabel1.Size = new System.Drawing.Size(13, 13);
            this.maxLabel1.TabIndex = 25;
            this.maxLabel1.Text = "0";
            // 
            // emaLabel1
            // 
            this.emaLabel1.AutoSize = true;
            this.emaLabel1.Location = new System.Drawing.Point(49, 113);
            this.emaLabel1.Name = "emaLabel1";
            this.emaLabel1.Size = new System.Drawing.Size(13, 13);
            this.emaLabel1.TabIndex = 26;
            this.emaLabel1.Text = "0";
            // 
            // resetStatsBtn
            // 
            this.resetStatsBtn.Location = new System.Drawing.Point(12, 140);
            this.resetStatsBtn.Name = "resetStatsBtn";
            this.resetStatsBtn.Size = new System.Drawing.Size(75, 23);
            this.resetStatsBtn.TabIndex = 27;
            this.resetStatsBtn.Text = "Reset";
            this.resetStatsBtn.UseVisualStyleBackColor = true;
            this.resetStatsBtn.Click += new System.EventHandler(this.resetStatsBtn_Click);
            // 
            // emaLabel2
            // 
            this.emaLabel2.AutoSize = true;
            this.emaLabel2.Location = new System.Drawing.Point(175, 115);
            this.emaLabel2.Name = "emaLabel2";
            this.emaLabel2.Size = new System.Drawing.Size(13, 13);
            this.emaLabel2.TabIndex = 33;
            this.emaLabel2.Text = "0";
            // 
            // maxLabel2
            // 
            this.maxLabel2.AutoSize = true;
            this.maxLabel2.Location = new System.Drawing.Point(175, 92);
            this.maxLabel2.Name = "maxLabel2";
            this.maxLabel2.Size = new System.Drawing.Size(13, 13);
            this.maxLabel2.TabIndex = 32;
            this.maxLabel2.Text = "0";
            // 
            // minLabel2
            // 
            this.minLabel2.AutoSize = true;
            this.minLabel2.Location = new System.Drawing.Point(175, 70);
            this.minLabel2.Name = "minLabel2";
            this.minLabel2.Size = new System.Drawing.Size(13, 13);
            this.minLabel2.TabIndex = 31;
            this.minLabel2.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(139, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "EMA:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(139, 92);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "MAX:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(139, 70);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 28;
            this.label12.Text = "MIN:";
            // 
            // emaLabel3
            // 
            this.emaLabel3.AutoSize = true;
            this.emaLabel3.Location = new System.Drawing.Point(297, 115);
            this.emaLabel3.Name = "emaLabel3";
            this.emaLabel3.Size = new System.Drawing.Size(13, 13);
            this.emaLabel3.TabIndex = 39;
            this.emaLabel3.Text = "0";
            // 
            // maxLabel3
            // 
            this.maxLabel3.AutoSize = true;
            this.maxLabel3.Location = new System.Drawing.Point(297, 92);
            this.maxLabel3.Name = "maxLabel3";
            this.maxLabel3.Size = new System.Drawing.Size(13, 13);
            this.maxLabel3.TabIndex = 38;
            this.maxLabel3.Text = "0";
            // 
            // minLabel3
            // 
            this.minLabel3.AutoSize = true;
            this.minLabel3.Location = new System.Drawing.Point(297, 70);
            this.minLabel3.Name = "minLabel3";
            this.minLabel3.Size = new System.Drawing.Size(13, 13);
            this.minLabel3.TabIndex = 37;
            this.minLabel3.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(261, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 13);
            this.label16.TabIndex = 36;
            this.label16.Text = "EMA:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(261, 92);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "MAX:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(261, 70);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(30, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "MIN:";
            // 
            // emaLabel4
            // 
            this.emaLabel4.AutoSize = true;
            this.emaLabel4.Location = new System.Drawing.Point(416, 115);
            this.emaLabel4.Name = "emaLabel4";
            this.emaLabel4.Size = new System.Drawing.Size(13, 13);
            this.emaLabel4.TabIndex = 45;
            this.emaLabel4.Text = "0";
            // 
            // maxLabel4
            // 
            this.maxLabel4.AutoSize = true;
            this.maxLabel4.Location = new System.Drawing.Point(416, 92);
            this.maxLabel4.Name = "maxLabel4";
            this.maxLabel4.Size = new System.Drawing.Size(13, 13);
            this.maxLabel4.TabIndex = 44;
            this.maxLabel4.Text = "0";
            // 
            // minLabel4
            // 
            this.minLabel4.AutoSize = true;
            this.minLabel4.Location = new System.Drawing.Point(416, 70);
            this.minLabel4.Name = "minLabel4";
            this.minLabel4.Size = new System.Drawing.Size(13, 13);
            this.minLabel4.TabIndex = 43;
            this.minLabel4.Text = "0";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(380, 115);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 42;
            this.label22.Text = "EMA:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(380, 92);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(33, 13);
            this.label23.TabIndex = 41;
            this.label23.Text = "MAX:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(380, 70);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(30, 13);
            this.label24.TabIndex = 40;
            this.label24.Text = "MIN:";
            // 
            // emaLabel5
            // 
            this.emaLabel5.AutoSize = true;
            this.emaLabel5.Location = new System.Drawing.Point(531, 115);
            this.emaLabel5.Name = "emaLabel5";
            this.emaLabel5.Size = new System.Drawing.Size(13, 13);
            this.emaLabel5.TabIndex = 51;
            this.emaLabel5.Text = "0";
            // 
            // maxLabel5
            // 
            this.maxLabel5.AutoSize = true;
            this.maxLabel5.Location = new System.Drawing.Point(531, 92);
            this.maxLabel5.Name = "maxLabel5";
            this.maxLabel5.Size = new System.Drawing.Size(13, 13);
            this.maxLabel5.TabIndex = 50;
            this.maxLabel5.Text = "0";
            // 
            // minLabel5
            // 
            this.minLabel5.AutoSize = true;
            this.minLabel5.Location = new System.Drawing.Point(531, 70);
            this.minLabel5.Name = "minLabel5";
            this.minLabel5.Size = new System.Drawing.Size(13, 13);
            this.minLabel5.TabIndex = 49;
            this.minLabel5.Text = "0";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(495, 115);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(33, 13);
            this.label28.TabIndex = 48;
            this.label28.Text = "EMA:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(495, 92);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(33, 13);
            this.label29.TabIndex = 47;
            this.label29.Text = "MAX:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(495, 70);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(30, 13);
            this.label30.TabIndex = 46;
            this.label30.Text = "MIN:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 654);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Min value:";
            // 
            // minValueTextBox
            // 
            this.minValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.minValueTextBox.Location = new System.Drawing.Point(343, 651);
            this.minValueTextBox.Name = "minValueTextBox";
            this.minValueTextBox.Size = new System.Drawing.Size(56, 20);
            this.minValueTextBox.TabIndex = 52;
            this.minValueTextBox.Text = "0";
            this.minValueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComPortsBaudDropdown_KeyPress);
            // 
            // setMinValueBtn
            // 
            this.setMinValueBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.setMinValueBtn.Location = new System.Drawing.Point(405, 649);
            this.setMinValueBtn.Name = "setMinValueBtn";
            this.setMinValueBtn.Size = new System.Drawing.Size(61, 23);
            this.setMinValueBtn.TabIndex = 54;
            this.setMinValueBtn.Text = "Set";
            this.setMinValueBtn.UseVisualStyleBackColor = true;
            this.setMinValueBtn.Click += new System.EventHandler(this.setMinValueBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 697);
            this.Controls.Add(this.setMinValueBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minValueTextBox);
            this.Controls.Add(this.emaLabel5);
            this.Controls.Add(this.maxLabel5);
            this.Controls.Add(this.minLabel5);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.emaLabel4);
            this.Controls.Add(this.maxLabel4);
            this.Controls.Add(this.minLabel4);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.emaLabel3);
            this.Controls.Add(this.maxLabel3);
            this.Controls.Add(this.minLabel3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.emaLabel2);
            this.Controls.Add(this.maxLabel2);
            this.Controls.Add(this.minLabel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.resetStatsBtn);
            this.Controls.Add(this.emaLabel1);
            this.Controls.Add(this.maxLabel1);
            this.Controls.Add(this.minLabel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.animateCheckBox);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.spanLabel);
            this.Controls.Add(this.resetZoomAndPanBtn);
            this.Controls.Add(this.zoomTextBox);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.textBox1);
            this.Name = "MainForm";
            this.Text = "Graphomaniac";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private LiveCharts.WinForms.CartesianChart chart;
        private System.Windows.Forms.TextBox zoomTextBox;
        private System.Windows.Forms.Button resetZoomAndPanBtn;
        private System.Windows.Forms.Button pauseBtn;
        private System.Windows.Forms.Label spanLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox connOptsStopBitsDropdown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox connOptsDataBitsDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox connOptsParityDropdown;
        private System.Windows.Forms.Label comsPortsParityLabel;
        private System.Windows.Forms.ComboBox connOptsBaudDropdown;
        private System.Windows.Forms.Label comPortsBaudLabel;
        private System.Windows.Forms.Button comPortsConnectBtn;
        private System.Windows.Forms.Button comPortsReloadBtn;
        private System.Windows.Forms.ComboBox connOptsPortsComboBox;
        private System.Windows.Forms.Label label1;
        private LiveCharts.WinForms.CartesianChart chart2;
        private System.Windows.Forms.CheckBox animateCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label minLabel1;
        private System.Windows.Forms.Label maxLabel1;
        private System.Windows.Forms.Label emaLabel1;
        private System.Windows.Forms.Button resetStatsBtn;
        private System.Windows.Forms.Label emaLabel2;
        private System.Windows.Forms.Label maxLabel2;
        private System.Windows.Forms.Label minLabel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label emaLabel3;
        private System.Windows.Forms.Label maxLabel3;
        private System.Windows.Forms.Label minLabel3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label emaLabel4;
        private System.Windows.Forms.Label maxLabel4;
        private System.Windows.Forms.Label minLabel4;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label maxLabel5;
        private System.Windows.Forms.Label minLabel5;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label emaLabel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minValueTextBox;
        private System.Windows.Forms.Button setMinValueBtn;
    }
}

