
_main:

;Control Moteur.c,2 :: 		void main()
;Control Moteur.c,4 :: 		PWM1_Init(4000);           // Initialize PWM1 module at 4KHz
	BSF        T2CON+0, 0
	BCF        T2CON+0, 1
	MOVLW      124
	MOVWF      PR2+0
	CALL       _PWM1_Init+0
;Control Moteur.c,5 :: 		PWM1_Start();              // start PWM1
	CALL       _PWM1_Start+0
;Control Moteur.c,6 :: 		PWM1_Set_Duty(127);        // Set current duty for PWM1 to 50%
	MOVLW      127
	MOVWF      FARG_PWM1_Set_Duty_new_duty+0
	CALL       _PWM1_Set_Duty+0
;Control Moteur.c,7 :: 		TRISD = 0;
	CLRF       TRISD+0
;Control Moteur.c,8 :: 		UART1_Init(9600);          // Initialize UART module at 9600 bps
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;Control Moteur.c,9 :: 		delay_ms(1000);            // Accélération
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main0:
	DECFSZ     R13+0, 1
	GOTO       L_main0
	DECFSZ     R12+0, 1
	GOTO       L_main0
	DECFSZ     R11+0, 1
	GOTO       L_main0
	NOP
	NOP
;Control Moteur.c,10 :: 		while(1)
L_main1:
;Control Moteur.c,12 :: 		if(UART1_Data_Ready())
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main3
;Control Moteur.c,14 :: 		uart_rd = UART1_Read();
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _uart_rd+0
;Control Moteur.c,15 :: 		if ( uart_rd=='1'){ PORTD.B0 = 1 ; PORTD.B1 = 0 ; PORTD.B4 = 0 ; PORTD.B5 = 1 ; Delay_ms(1000); }
	MOVF       R0+0, 0
	XORLW      49
	BTFSS      STATUS+0, 2
	GOTO       L_main4
	BSF        PORTD+0, 0
	BCF        PORTD+0, 1
	BCF        PORTD+0, 4
	BSF        PORTD+0, 5
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main5:
	DECFSZ     R13+0, 1
	GOTO       L_main5
	DECFSZ     R12+0, 1
	GOTO       L_main5
	DECFSZ     R11+0, 1
	GOTO       L_main5
	NOP
	NOP
L_main4:
;Control Moteur.c,16 :: 		if ( uart_rd=='2'){ PORTD.B0 = 0 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 0 ; Delay_ms(1000); }
	MOVF       _uart_rd+0, 0
	XORLW      50
	BTFSS      STATUS+0, 2
	GOTO       L_main6
	BCF        PORTD+0, 0
	BSF        PORTD+0, 1
	BSF        PORTD+0, 4
	BCF        PORTD+0, 5
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main7:
	DECFSZ     R13+0, 1
	GOTO       L_main7
	DECFSZ     R12+0, 1
	GOTO       L_main7
	DECFSZ     R11+0, 1
	GOTO       L_main7
	NOP
	NOP
L_main6:
;Control Moteur.c,17 :: 		if ( uart_rd=='3'){ PORTD.B0 = 1 ; PORTD.B1 = 0 ; PORTD.B4 = 1 ; PORTD.B5 = 1 ; Delay_ms(1000); }
	MOVF       _uart_rd+0, 0
	XORLW      51
	BTFSS      STATUS+0, 2
	GOTO       L_main8
	BSF        PORTD+0, 0
	BCF        PORTD+0, 1
	BSF        PORTD+0, 4
	BSF        PORTD+0, 5
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main9:
	DECFSZ     R13+0, 1
	GOTO       L_main9
	DECFSZ     R12+0, 1
	GOTO       L_main9
	DECFSZ     R11+0, 1
	GOTO       L_main9
	NOP
	NOP
L_main8:
;Control Moteur.c,18 :: 		if ( uart_rd=='4'){ PORTD.B0 = 1 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 0 ; Delay_ms(1000); }
	MOVF       _uart_rd+0, 0
	XORLW      52
	BTFSS      STATUS+0, 2
	GOTO       L_main10
	BSF        PORTD+0, 0
	BSF        PORTD+0, 1
	BSF        PORTD+0, 4
	BCF        PORTD+0, 5
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main11:
	DECFSZ     R13+0, 1
	GOTO       L_main11
	DECFSZ     R12+0, 1
	GOTO       L_main11
	DECFSZ     R11+0, 1
	GOTO       L_main11
	NOP
	NOP
L_main10:
;Control Moteur.c,19 :: 		if ( uart_rd=='5'){ PORTD.B0 = 1 ; PORTD.B1 = 1 ; PORTD.B4 = 1 ; PORTD.B5 = 1 ; Delay_ms(1000); }
	MOVF       _uart_rd+0, 0
	XORLW      53
	BTFSS      STATUS+0, 2
	GOTO       L_main12
	BSF        PORTD+0, 0
	BSF        PORTD+0, 1
	BSF        PORTD+0, 4
	BSF        PORTD+0, 5
	MOVLW      11
	MOVWF      R11+0
	MOVLW      38
	MOVWF      R12+0
	MOVLW      93
	MOVWF      R13+0
L_main13:
	DECFSZ     R13+0, 1
	GOTO       L_main13
	DECFSZ     R12+0, 1
	GOTO       L_main13
	DECFSZ     R11+0, 1
	GOTO       L_main13
	NOP
	NOP
L_main12:
;Control Moteur.c,20 :: 		}
L_main3:
;Control Moteur.c,21 :: 		}
	GOTO       L_main1
;Control Moteur.c,22 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
