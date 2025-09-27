
char ala;
int val_1 , val_2 , val_3;
unsigned int res1,res2,res3;
char txt1[10],txt2[10],txt3[10];

 void newline()
  {
  uart1_write(13);
  uart1_write(10);
  }
  void main()
{
  UART1_Init(9600);
  ADC_Init();
  TRISA  = 0xFF;              // PORTA is input
  while(1)
  {
  
   if (UART1_Data_Ready()) {     // If data is received,
      ala = UART1_Read();     // read the received data,
      if (ala == 'A') {
      
     val_1 = adc_read(0);
     val_2 = adc_read(1);
     val_3 = adc_read(2);

     res1 = val_1;
     res2 = val_2;
     res3 = val_3;

     IntToStr(res1, txt1);
     IntToStr(res2, txt2);
     IntToStr(res3, txt3);

     uart1_write_text(txt1);
     uart1_write_text("#");
     uart1_write_text(txt2);
     uart1_write_text("#");
     uart1_write_text(txt3);

     delay_ms(100);         // Accélération
     newline();
      }
    }
  }
}