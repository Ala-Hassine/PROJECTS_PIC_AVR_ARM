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
     y=(x*500)/1024;        // formule pour calcule la température
     IntToStr(y, txt1);
     uart1_write_text(txt1);
     delay_ms(1000);         // Accélération
     newline();
  }
}