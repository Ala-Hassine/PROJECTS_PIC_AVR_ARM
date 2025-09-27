#line 1 "C:/Users/Ala Hassine/Desktop/Control deux Moteurs Via PIC16F877A et Visual Studio/Code mikroC/Control Moteur.c"
char uart_rd;
void main()
 {
 PWM1_Init(4000);
 PWM1_Start();
 PWM1_Set_Duty(127);
 TRISD = 0;
 UART1_Init(9600);
 delay_ms(1000);
 while(1)
 {
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
