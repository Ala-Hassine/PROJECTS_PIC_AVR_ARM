
_main:

;Temperature.c,5 :: 		void main()
;Temperature.c,7 :: 		UART1_Init(9600);
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;Temperature.c,8 :: 		while(1)
L_main0:
;Temperature.c,10 :: 		if (UART1_Data_Ready()) {     // If data is received,
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main2
;Temperature.c,11 :: 		ala = UART1_Read();     // read the received data,
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _ala+0
;Temperature.c,12 :: 		if (ala == 'A')
	MOVF       R0+0, 0
	XORLW      65
	BTFSS      STATUS+0, 2
	GOTO       L_main3
;Temperature.c,14 :: 		x = adc_read(0);
	CLRF       FARG_ADC_Read_channel+0
	CALL       _ADC_Read+0
	CALL       _word2double+0
	MOVF       R0+0, 0
	MOVWF      _x+0
	MOVF       R0+1, 0
	MOVWF      _x+1
	MOVF       R0+2, 0
	MOVWF      _x+2
	MOVF       R0+3, 0
	MOVWF      _x+3
;Temperature.c,15 :: 		y = ( x * 500) / 1024;        // formule pour calcule la température
	MOVLW      0
	MOVWF      R4+0
	MOVLW      0
	MOVWF      R4+1
	MOVLW      122
	MOVWF      R4+2
	MOVLW      135
	MOVWF      R4+3
	CALL       _Mul_32x32_FP+0
	MOVLW      0
	MOVWF      R4+0
	MOVLW      0
	MOVWF      R4+1
	MOVLW      0
	MOVWF      R4+2
	MOVLW      137
	MOVWF      R4+3
	CALL       _Div_32x32_FP+0
	MOVF       R0+0, 0
	MOVWF      _y+0
	MOVF       R0+1, 0
	MOVWF      _y+1
	MOVF       R0+2, 0
	MOVWF      _y+2
	MOVF       R0+3, 0
	MOVWF      _y+3
;Temperature.c,16 :: 		FloatToStr(y, txt1);
	MOVF       R0+0, 0
	MOVWF      FARG_FloatToStr_fnum+0
	MOVF       R0+1, 0
	MOVWF      FARG_FloatToStr_fnum+1
	MOVF       R0+2, 0
	MOVWF      FARG_FloatToStr_fnum+2
	MOVF       R0+3, 0
	MOVWF      FARG_FloatToStr_fnum+3
	MOVLW      _txt1+0
	MOVWF      FARG_FloatToStr_str+0
	CALL       _FloatToStr+0
;Temperature.c,17 :: 		uart1_write_text(txt1);
	MOVLW      _txt1+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;Temperature.c,18 :: 		}
L_main3:
;Temperature.c,19 :: 		delay_ms(100);         // Accélération
	MOVLW      2
	MOVWF      R11+0
	MOVLW      4
	MOVWF      R12+0
	MOVLW      186
	MOVWF      R13+0
L_main4:
	DECFSZ     R13+0, 1
	GOTO       L_main4
	DECFSZ     R12+0, 1
	GOTO       L_main4
	DECFSZ     R11+0, 1
	GOTO       L_main4
	NOP
;Temperature.c,20 :: 		}
L_main2:
;Temperature.c,21 :: 		}
	GOTO       L_main0
;Temperature.c,22 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
