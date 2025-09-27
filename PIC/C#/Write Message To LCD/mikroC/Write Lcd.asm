
_main:

;Write Lcd.c,18 :: 		void main(){
;Write Lcd.c,19 :: 		Lcd_init();
	CALL       _Lcd_Init+0
;Write Lcd.c,20 :: 		UART1_init(9600); // initialize USART module
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;Write Lcd.c,21 :: 		LCD_Cmd(_LCD_CLEAR); // Clear display
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Write Lcd.c,22 :: 		LCD_Cmd(_LCD_CURSOR_OFF); // Turn cursor off
	MOVLW      12
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Write Lcd.c,23 :: 		Lcd_Out(1,3,txt1);
	MOVLW      1
	MOVWF      FARG_Lcd_Out_row+0
	MOVLW      3
	MOVWF      FARG_Lcd_Out_column+0
	MOVLW      _txt1+0
	MOVWF      FARG_Lcd_Out_text+0
	CALL       _Lcd_Out+0
;Write Lcd.c,24 :: 		delay_ms(2000);
	MOVLW      21
	MOVWF      R11+0
	MOVLW      75
	MOVWF      R12+0
	MOVLW      190
	MOVWF      R13+0
L_main0:
	DECFSZ     R13+0, 1
	GOTO       L_main0
	DECFSZ     R12+0, 1
	GOTO       L_main0
	DECFSZ     R11+0, 1
	GOTO       L_main0
	NOP
;Write Lcd.c,25 :: 		LCD_Cmd(_LCD_CLEAR); // Clear display
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Write Lcd.c,26 :: 		while (1) {
L_main1:
;Write Lcd.c,27 :: 		if (UART1_Data_Ready()) { // if data is received
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main3
;Write Lcd.c,28 :: 		i = UART1_Read();
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _i+0
	CLRF       _i+1
;Write Lcd.c,29 :: 		if (i==65) { // if recieve CR
	MOVLW      0
	XORWF      _i+1, 0
	BTFSS      STATUS+0, 2
	GOTO       L__main7
	MOVLW      65
	XORWF      _i+0, 0
L__main7:
	BTFSS      STATUS+0, 2
	GOTO       L_main4
;Write Lcd.c,30 :: 		LCD_Cmd(_LCD_CLEAR); //clear LCD
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Write Lcd.c,31 :: 		LCD_Cmd(_LCD_RETURN_HOME); //Return Home
	MOVLW      2
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;Write Lcd.c,32 :: 		}
	GOTO       L_main5
L_main4:
;Write Lcd.c,35 :: 		LCD_Chr_Cp(i); //write data to lcd
	MOVF       _i+0, 0
	MOVWF      FARG_Lcd_Chr_CP_out_char+0
	CALL       _Lcd_Chr_CP+0
;Write Lcd.c,36 :: 		}
L_main5:
;Write Lcd.c,37 :: 		}
L_main3:
;Write Lcd.c,38 :: 		}
	GOTO       L_main1
;Write Lcd.c,39 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
