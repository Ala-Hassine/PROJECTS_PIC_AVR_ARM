
_main:

;LCD.c,20 :: 		void main()
;LCD.c,23 :: 		Lcd_init();
	CALL       _Lcd_Init+0
;LCD.c,24 :: 		UART1_init(9600); // initialize USART module
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;LCD.c,25 :: 		LCD_Cmd(_LCD_CLEAR); // Clear display
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;LCD.c,26 :: 		LCD_Cmd(_LCD_CURSOR_OFF); // Turn cursor off
	MOVLW      12
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;LCD.c,27 :: 		Lcd_Out(1,1,txt);
	MOVLW      1
	MOVWF      FARG_Lcd_Out_row+0
	MOVLW      1
	MOVWF      FARG_Lcd_Out_column+0
	MOVLW      _txt+0
	MOVWF      FARG_Lcd_Out_text+0
	CALL       _Lcd_Out+0
;LCD.c,28 :: 		delay_ms(2000);
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
;LCD.c,29 :: 		LCD_Cmd(_LCD_CLEAR); // Clear display
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;LCD.c,31 :: 		while (1) {
L_main1:
;LCD.c,32 :: 		if (UART1_Data_Ready()) { // if data is received
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main3
;LCD.c,33 :: 		ala = UART1_Read();
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _ala+0
;LCD.c,34 :: 		if (ala == 'A') { // if recieve CR
	MOVF       R0+0, 0
	XORLW      65
	BTFSS      STATUS+0, 2
	GOTO       L_main4
;LCD.c,35 :: 		LCD_Cmd(_LCD_CLEAR);              //clear LCD
	MOVLW      1
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;LCD.c,36 :: 		LCD_Cmd(_LCD_RETURN_HOME);        //Return Home
	MOVLW      2
	MOVWF      FARG_Lcd_Cmd_out_char+0
	CALL       _Lcd_Cmd+0
;LCD.c,37 :: 		}
	GOTO       L_main5
L_main4:
;LCD.c,40 :: 		LCD_Chr_Cp(ala); //write data to lcd
	MOVF       _ala+0, 0
	MOVWF      FARG_Lcd_Chr_CP_out_char+0
	CALL       _Lcd_Chr_CP+0
;LCD.c,41 :: 		}
L_main5:
;LCD.c,42 :: 		}
L_main3:
;LCD.c,43 :: 		}
	GOTO       L_main1
;LCD.c,44 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
