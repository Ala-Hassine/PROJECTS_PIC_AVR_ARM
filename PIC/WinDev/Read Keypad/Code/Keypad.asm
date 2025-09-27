
_get_key:

;Keypad.c,9 :: 		char get_key()
;Keypad.c,11 :: 		ala:
___get_key_ala:
;Keypad.c,12 :: 		while (kp[i] == 0)
L_get_key0:
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      0
	BTFSS      STATUS+0, 2
	GOTO       L_get_key1
;Keypad.c,14 :: 		kp[i] = Keypad_Key_Click();
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FLOC__get_key+0
	CALL       _Keypad_Key_Click+0
	MOVF       FLOC__get_key+0, 0
	MOVWF      FSR
	MOVF       R0+0, 0
	MOVWF      INDF+0
;Keypad.c,15 :: 		}
	GOTO       L_get_key0
L_get_key1:
;Keypad.c,16 :: 		if(kp[i] == 1)     { kp[i]  = '1'; UART1_Write('1'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      1
	BTFSS      STATUS+0, 2
	GOTO       L_get_key2
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      49
	MOVWF      INDF+0
	MOVLW      49
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key2:
;Keypad.c,17 :: 		if(kp[i] == 2)     { kp[i]  = '2'; UART1_Write('2'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      2
	BTFSS      STATUS+0, 2
	GOTO       L_get_key3
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      50
	MOVWF      INDF+0
	MOVLW      50
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key3:
;Keypad.c,18 :: 		if(kp[i] == 3)     { kp[i]  = '3'; UART1_Write('3'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      3
	BTFSS      STATUS+0, 2
	GOTO       L_get_key4
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      51
	MOVWF      INDF+0
	MOVLW      51
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key4:
;Keypad.c,19 :: 		if(kp[i] == 5)     { kp[i]  = '4'; UART1_Write('4'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      5
	BTFSS      STATUS+0, 2
	GOTO       L_get_key5
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      52
	MOVWF      INDF+0
	MOVLW      52
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key5:
;Keypad.c,20 :: 		if(kp[i] == 6)     { kp[i]  = '5'; UART1_Write('5'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      6
	BTFSS      STATUS+0, 2
	GOTO       L_get_key6
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      53
	MOVWF      INDF+0
	MOVLW      53
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key6:
;Keypad.c,21 :: 		if(kp[i] == 7)     { kp[i]  = '6'; UART1_Write('6'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      7
	BTFSS      STATUS+0, 2
	GOTO       L_get_key7
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      54
	MOVWF      INDF+0
	MOVLW      54
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key7:
;Keypad.c,22 :: 		if(kp[i] == 9)     { kp[i]  = '7'; UART1_Write('7'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      9
	BTFSS      STATUS+0, 2
	GOTO       L_get_key8
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      55
	MOVWF      INDF+0
	MOVLW      55
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key8:
;Keypad.c,23 :: 		if(kp[i] == 10)    { kp[i]  = '8'; UART1_Write('8'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      10
	BTFSS      STATUS+0, 2
	GOTO       L_get_key9
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      56
	MOVWF      INDF+0
	MOVLW      56
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key9:
;Keypad.c,24 :: 		if(kp[i] == 11)    { kp[i]  = '9'; UART1_Write('9'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      11
	BTFSS      STATUS+0, 2
	GOTO       L_get_key10
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      57
	MOVWF      INDF+0
	MOVLW      57
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key10:
;Keypad.c,25 :: 		if(kp[i] == 13)    { kp[i]  = '*'; UART1_Write('*'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      13
	BTFSS      STATUS+0, 2
	GOTO       L_get_key11
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      42
	MOVWF      INDF+0
	MOVLW      42
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key11:
;Keypad.c,26 :: 		if(kp[i] == 14)    { kp[i]  = '0'; UART1_Write('0'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      14
	BTFSS      STATUS+0, 2
	GOTO       L_get_key12
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      48
	MOVWF      INDF+0
	MOVLW      48
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key12:
;Keypad.c,27 :: 		if(kp[i] == 15)    { kp[i]  = '#'; UART1_Write('#'); }
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORLW      15
	BTFSS      STATUS+0, 2
	GOTO       L_get_key13
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVLW      35
	MOVWF      INDF+0
	MOVLW      35
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
L_get_key13:
;Keypad.c,29 :: 		if (kp[i] != oldstate) {                  // Pressed key differs from previous
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	XORWF      _oldstate+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_get_key14
;Keypad.c,30 :: 		oldstate = kp[i];
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	MOVF       INDF+0, 0
	MOVWF      _oldstate+0
;Keypad.c,31 :: 		}
	GOTO       L_get_key15
L_get_key14:
;Keypad.c,34 :: 		kp[i] = 0;
	MOVF       _i+0, 0
	ADDLW      _kp+0
	MOVWF      FSR
	CLRF       INDF+0
;Keypad.c,35 :: 		goto ala;
	GOTO       ___get_key_ala
;Keypad.c,36 :: 		}
L_get_key15:
;Keypad.c,37 :: 		}
L_end_get_key:
	RETURN
; end of _get_key

_main:

;Keypad.c,39 :: 		void main()
;Keypad.c,41 :: 		UART1_Init(9600);
	MOVLW      51
	MOVWF      SPBRG+0
	BSF        TXSTA+0, 2
	CALL       _UART1_Init+0
;Keypad.c,42 :: 		UART1_Write_Text("KeyPad 4*3");
	MOVLW      ?lstr1_Keypad+0
	MOVWF      FARG_UART1_Write_Text_uart_text+0
	CALL       _UART1_Write_Text+0
;Keypad.c,43 :: 		UART1_Write(10);
	MOVLW      10
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;Keypad.c,44 :: 		UART1_Write(13);
	MOVLW      13
	MOVWF      FARG_UART1_Write_data_+0
	CALL       _UART1_Write+0
;Keypad.c,45 :: 		keypad_Init();
	CALL       _Keypad_Init+0
;Keypad.c,47 :: 		while(1) {
L_main16:
;Keypad.c,48 :: 		if (UART1_Data_Ready()) // If data is received,
	CALL       _UART1_Data_Ready+0
	MOVF       R0+0, 0
	BTFSC      STATUS+0, 2
	GOTO       L_main18
;Keypad.c,50 :: 		ala = UART1_Read();     // read the received data,
	CALL       _UART1_Read+0
	MOVF       R0+0, 0
	MOVWF      _ala+0
;Keypad.c,51 :: 		if (ala == 'A') get_key();
	MOVF       R0+0, 0
	XORLW      65
	BTFSS      STATUS+0, 2
	GOTO       L_main19
	CALL       _get_key+0
L_main19:
;Keypad.c,52 :: 		}
L_main18:
;Keypad.c,53 :: 		}
	GOTO       L_main16
;Keypad.c,54 :: 		}
L_end_main:
	GOTO       $+0
; end of _main
