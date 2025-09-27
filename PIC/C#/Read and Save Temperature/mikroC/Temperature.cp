#line 1 "C:/Users/aala/Desktop/Projects/Read and Save Température Via PIC16F877A and C#/mikroC/Temperature.c"
 char txt1 [20];
 float x;
 int y;
 void newline()
 {
 uart1_write(13);
 uart1_write(10);
 }
 void main()
{
 UART1_Init(9600);
 while(1)
 {
 x=adc_read(0);
 y=(x*500)/1024;
 IntToStr(y, txt1);
 uart1_write_text(txt1);
 delay_ms(1000);
 newline();
 }
}
