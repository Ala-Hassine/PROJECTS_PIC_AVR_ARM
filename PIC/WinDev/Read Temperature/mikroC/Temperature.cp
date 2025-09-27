#line 1 "C:/Users/aala/Desktop/Content/ala/Read Température Via PIC16F877A and WinDev/mikroC/Temperature.c"
char txt1[10];
float x,y;
char ala;

void main()
{
UART1_Init(9600);
 while(1)
 {
 if (UART1_Data_Ready()) {
 ala = UART1_Read();
 if (ala == 'A')
 {
 x = adc_read(0);
 y = ( x * 500) / 1024;
 FloatToStr(y, txt1);
 uart1_write_text(txt1);
 }
 delay_ms(100);
 }
 }
}
