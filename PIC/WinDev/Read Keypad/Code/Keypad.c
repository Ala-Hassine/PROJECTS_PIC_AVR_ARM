
char ala;
unsigned short oldstate = 0;
char  keypadPort at PORTB;
int i;

char kp[] = "";

char get_key()
{
    ala:
    while (kp[i] == 0)
    {
     kp[i] = Keypad_Key_Click();
    }
    if(kp[i] == 1)     { kp[i]  = '1'; UART1_Write('1'); }
    if(kp[i] == 2)     { kp[i]  = '2'; UART1_Write('2'); }
    if(kp[i] == 3)     { kp[i]  = '3'; UART1_Write('3'); }
    if(kp[i] == 5)     { kp[i]  = '4'; UART1_Write('4'); }
    if(kp[i] == 6)     { kp[i]  = '5'; UART1_Write('5'); }
    if(kp[i] == 7)     { kp[i]  = '6'; UART1_Write('6'); }
    if(kp[i] == 9)     { kp[i]  = '7'; UART1_Write('7'); }
    if(kp[i] == 10)    { kp[i]  = '8'; UART1_Write('8'); }
    if(kp[i] == 11)    { kp[i]  = '9'; UART1_Write('9'); }
    if(kp[i] == 13)    { kp[i]  = '*'; UART1_Write('*'); }
    if(kp[i] == 14)    { kp[i]  = '0'; UART1_Write('0'); }
    if(kp[i] == 15)    { kp[i]  = '#'; UART1_Write('#'); }
    
    if (kp[i] != oldstate) {                  // Pressed key differs from previous
      oldstate = kp[i];
    }
    else
     {
       kp[i] = 0;
       goto ala;
     }
}

void main() 
{
    UART1_Init(9600);
    UART1_Write_Text("KeyPad 4*3");
    UART1_Write(10);
    UART1_Write(13);
    keypad_Init();

    while(1) {
    if (UART1_Data_Ready()) // If data is received,
       {
        ala = UART1_Read();     // read the received data,
        if (ala == 'A') get_key();
       }
    }
}