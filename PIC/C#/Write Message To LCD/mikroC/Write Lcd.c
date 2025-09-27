////////////// Déclaration de LCD //////////////
sbit LCD_RS at RB0_bit;
sbit LCD_EN at RB2_bit;
sbit LCD_D4 at RB3_bit;
sbit LCD_D5 at RB4_bit;
sbit LCD_D6 at RB5_bit;
sbit LCD_D7 at RB6_bit;

sbit LCD_RS_Direction at TRISB0_bit;
sbit LCD_EN_Direction at TRISB2_bit;
sbit LCD_D4_Direction at TRISB3_bit;
sbit LCD_D5_Direction at TRISB4_bit;
sbit LCD_D6_Direction at TRISB5_bit;
sbit LCD_D7_Direction at TRISB6_bit;
char txt1[] = "Ala Hassine";
int i;

void main(){
    Lcd_init();
    UART1_init(9600); // initialize USART module
    LCD_Cmd(_LCD_CLEAR); // Clear display
    LCD_Cmd(_LCD_CURSOR_OFF); // Turn cursor off
    Lcd_Out(1,3,txt1);
    delay_ms(2000);
    LCD_Cmd(_LCD_CLEAR); // Clear display
    while (1) {
        if (UART1_Data_Ready()) { // if data is received
        i = UART1_Read();
        if (i==65) { // if recieve CR
        LCD_Cmd(_LCD_CLEAR); //clear LCD
        LCD_Cmd(_LCD_RETURN_HOME); //Return Home
        }
         else 
         {
          LCD_Chr_Cp(i); //write data to lcd
         }
      }
    }
}