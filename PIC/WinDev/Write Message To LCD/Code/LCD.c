////////////// Déclaration de LCD //////////////
sbit LCD_RS at RC0_bit;
sbit LCD_EN at RC1_bit;
sbit LCD_D4 at RC2_bit;
sbit LCD_D5 at RC3_bit;
sbit LCD_D6 at RC4_bit;
sbit LCD_D7 at RC5_bit;

sbit LCD_RS_Direction at TRISC0_bit;
sbit LCD_EN_Direction at TRISC1_bit;
sbit LCD_D4_Direction at TRISC2_bit;
sbit LCD_D5_Direction at TRISC3_bit;
sbit LCD_D6_Direction at TRISC4_bit;
sbit LCD_D7_Direction at TRISC5_bit;

char txt[] = "EMBEDDED SYSTEM";
char ala;

void main()
{

    Lcd_init();
    UART1_init(9600); // initialize USART module
    LCD_Cmd(_LCD_CLEAR); // Clear display
    LCD_Cmd(_LCD_CURSOR_OFF); // Turn cursor off
    Lcd_Out(1,1,txt);
    delay_ms(2000);
    LCD_Cmd(_LCD_CLEAR); // Clear display
    
    while (1) 
    {
        if (UART1_Data_Ready()) 
        { 
        // if data is received
        ala = UART1_Read();
        if (ala == 'A') 
        { 
        // if recieve CR
            LCD_Cmd(_LCD_CLEAR);              //clear LCD
            LCD_Cmd(_LCD_RETURN_HOME);        //Return Home
        }
        else
        {
            LCD_Chr_Cp(ala); //write data to lcd
        }
      }
    }
}