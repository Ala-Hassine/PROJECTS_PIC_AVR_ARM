
_newline:

;ADC.c,7 :: 		void newline()
;ADC.c,9 :: 		uart1_write(13);
	MOVLW      13
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;ADC.c,10 :: 		uart1_write(10);
	MOVLW      10
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;ADC.c,11 :: 		}
L_end_newline:
	RETURN
; end of _newline

_main:

;ADC.c,12 :: 		void main()
;ADC.c,14 :: 		UART1_Init(9600);
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;ADC.c,15 :: 		ADC_Init();
	CALL       _ADC_Init+0
;ADC.c,16 :: 		TRISA  = 0xFF;              // PORTA is input
	MOVLW      255
	MOVWF      TRISA+0
;ADC.c,17 :: 		while(1)
L_main0:
;ADC.c,20 :: 		if (UART1_Data_Ready()) {     // If data is received,
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main2
;ADC.c,21 :: 		ala = UART1_Read();     // read the received data,
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _ala+0
;ADC.c,22 :: 		if (ala == 'A') {
	MOVF       R0+0, 0
	XORLW      65
	BTFSS      STATUS+0, 2
	GOTO       L_main3
;ADC.c,24 :: 		val_1 = adc_read(0);
	CLRF       FARG_ADC_Read_channel+0
	CALL       _ADC_Read+0
	MOVF       R0+0, 0
	MOVWF      _val_1+0
	MOVF       R0+1, 0
	MOVWF      _val_1+1
;ADC.c,25 :: 		val_2 = adc_read(1);
	MOVLW      1
	MOVWF      FARG_ADC_Read_channel+0
	CALL       _ADC_Read+0
	MOVF       R0+0, 0
	MOVWF      _val_2+0
	MOVF       R0+1, 0
	MOVWF      _val_2+1
;ADC.c,26 :: 		val_3 = adc_read(2);
	MOVLW      2
	MOVWF      FARG_ADC_Read_channel+0
	CALL       _ADC_Read+0
	MOVF       R0+0, 0
	MOVWF      _val_3+0
	MOVF       R0+1, 0
	MOVWF      _val_3+1
;ADC.c,28 :: 		res1 = val_1;
	MOVF       _val_1+0, 0
	MOVWF      _res1+0
	MOVF       _val_1+1, 0
	MOVWF      _res1+1
;ADC.c,29 :: 		res2 = val_2;
	MOVF       _val_2+0, 0
	MOVWF      _res2+0
	MOVF       _val_2+1, 0
	MOVWF      _res2+1
;ADC.c,30 :: 		res3 = val_3;
	MOVF       R0+0, 0
	MOVWF      _res3+0
	MOVF       R0+1, 0
	MOVWF      _res3+1
;ADC.c,32 :: 		IntToStr(res1, txt1);
	MOVF       _val_1+0, 0
	MOVWF      FARG_IntToStr_input+0
	MOVF       _val_1+1, 0
	MOVWF      FARG_IntToStr_input+1
	MOVLW      _txt1+0
	MOVWF      FARG_IntToStr_output+0
	CALL       _IntToStr+0
;ADC.c,33 :: 		IntToStr(res2, txt2);
	MOVF       _res2+0, 0
	MOVWF      FARG_IntToStr_input+0
	MOVF       _res2+1, 0
	MOVWF      FARG_IntToStr_input+1
	MOVLW      _txt2+0
	MOVWF      FARG_IntToStr_output+0
	CALL       _IntToStr+0
;ADC.c,34 :: 		IntToStr(res3, txt3);
	MOVF       _res3+0, 0
	MOVWF      FARG_IntToStr_input+0
	MOVF       _res3+1, 0
	MOVWF      FARG_IntToStr_input+1
	MOVLW      _txt3+0
	MOVWF      FARG_IntToStr_output+0
	CALL       _IntToStr+0
;ADC.c,36 :: 		uart1_write_text(txt1);
	MOVLW      _txt1+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;ADC.c,37 :: 		uart1_write_text("#");
	MOVLW      ?lstr1_ADC+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;ADC.c,38 :: 		uart1_write_text(txt2);
	MOVLW      _txt2+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;ADC.c,39 :: 		uart1_write_text("#");
	MOVLW      ?lstr2_ADC+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;ADC.c,40 :: 		uart1_write_text(txt3);
	MOVLW      _txt3+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;ADC.c,42 :: 		delay_ms(100);         // Accélération
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
;ADC.c,43 :: 		newline();
	CALL       _newline+0
;ADC.c,44 :: 		}
L_main3:
;ADC.c,45 :: 		}
L_main2:
;ADC.c,46 :: 		}
	GOTO       L_main0
;ADC.c,47 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
