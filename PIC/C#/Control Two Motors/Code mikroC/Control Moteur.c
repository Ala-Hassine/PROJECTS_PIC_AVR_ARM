char uart_rd;
void main() 
 {
   PWM1_Init(4000);           // Initialize PWM1 module at 4KHz
   PWM1_Start();              // start PWM1
   PWM1_Set_Duty(127);        // Set current duty for PWM1 to 50%
   TRISD = 0;
   UART1_Init(9600);          // Initialize UART module at 9600 bps
   delay_ms(1000);            // Accélération
   while(1)
     {                  // boucle infini
      if(UART1_Data_Ready())
        {
          uart_rd = UART1_Read();
            if ( uart_rd=='1'){ PORTD.B0 = 1 ; PORTD.B1 = 0 ; PORTD.B4 = 0 ; PORTD.B5 = 1 ; Delay_ms(1000); }
            if ( uart_rd=='2'){ PORTD.B0 = 0 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 0 ; Delay_ms(1000); }
            if ( uart_rd=='3'){ PORTD.B0 = 1 ; PORTD.B1 = 0 ; PORTD.B4 = 1 ; PORTD.B5 = 1 ; Delay_ms(1000); }
            if ( uart_rd=='4'){ PORTD.B0 = 1 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 0 ; Delay_ms(1000); }
            if ( uart_rd=='5'){ PORTD.B0 = 1 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 1 ; Delay_ms(1000); }
        }
     }
  }