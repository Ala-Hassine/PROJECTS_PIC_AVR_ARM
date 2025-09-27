
_newline:

;Temperature.c,4 :: 		void newline()
;Temperature.c,6 :: 		uart1_write(13);
	MOVLW      13
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;Temperature.c,7 :: 		uart1_write(10);
	MOVLW      10
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;Temperature.c,8 :: 		}
L_end_newline:
	RETURN
; end of _newline

_main:

;Temperature.c,9 :: 		void main()
;Temperature.c,11 :: 		UART1_Init(9600);
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;Temperature.c,12 :: 		while(1)
L_main0:
;Temperature.c,14 :: 		x=adc_read(0);
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
;Temperature.c,15 :: 		y=(x*500)/1024;        // formule pour calcule la température
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
	CALL       _double2int+0
	MOVF       R0+0, 0
	MOVWF      _y+0
	MOVF       R0+1, 0
	MOVWF      _y+1
;Temperature.c,16 :: 		IntToStr(y, txt1);
	MOVF       R0+0, 0
	MOVWF      FARG_IntToStr_input+0
	MOVF       R0+1, 0
	MOVWF      FARG_IntToStr_input+1
	MOVLW      _txt1+0
	MOVWF      FARG_IntToStr_output+0
	CALL       _IntToStr+0
;Temperature.c,17 :: 		uart1_write_text(txt1);
	MOVLW      _txt1+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;Temperature.c,18 :: 		delay_ms(1000);         // Accélération
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main2:
	DECFSZ     R13+0, 1
	GOTO       L_main2
	DECFSZ     R12+0, 1
	GOTO       L_main2
	DECFSZ     R11+0, 1
	GOTO       L_main2
	NOP
	NOP
;Temperature.c,19 :: 		newline();
	CALL       _newline+0
;Temperature.c,20 :: 		}
	GOTO       L_main0
;Temperature.c,21 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
