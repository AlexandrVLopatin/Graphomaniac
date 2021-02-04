# Graphomaniac
Serial port plotter


![Screenshot](https://github.com/AlexandrVLopatin/Graphomaniac/blob/main/screenshot.png)

Example data formatting:

```c
char result[40] = {0};

for (i = 0; i <= 3; i++)
{
    char temp[10] = "";
    if (i < 3)
        snprintf(temp, 10, "%d,", freq_bins[i]);
    else
        snprintf(temp, 10, "%d\n", freq_bins[i]);

    strcat(result, temp);
}

HAL_UART_Transmit(&huart2, (uint8_t *)result, strlen(result), 1000);
```
