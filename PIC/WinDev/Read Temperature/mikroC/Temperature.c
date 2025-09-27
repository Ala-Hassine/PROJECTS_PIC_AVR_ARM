char txt1[10];
float x,y;
char ala;

void main()
{
UART1_Init(9600);
  while(1)
  {
   if (UART1_Data_Ready()) {     // If data is received,
      ala = UART1_Read();     // read the received data,
      if (ala == 'A') 
      {
         x = adc_read(0);
         y = ( x * 500) / 1024;        // formule pour calcule la température
         FloatToStr(y, txt1);
         uart1_write_text(txt1);
      }
      delay_ms(100);         // Accélération
    }
  }
}