int led1  = 13;
int led2 = 12;
int led3 = 11;
int led4 = 10;

void setup() {
  Serial.begin( 9600 );
  pinMode( led1, OUTPUT );
  pinMode( led2, OUTPUT );
  pinMode( led3, OUTPUT );
  pinMode( led4, OUTPUT );
}

void loop() {
  if (Serial.available() > 0); {
    int data = Serial.read() - '0';
    switch (data) {
      case 1 : digitalWrite( led1, HIGH ); break;
      case 2 : digitalWrite( led1, LOW ); break;
      case 3 : digitalWrite( led2, HIGH ); break;
      case 4 : digitalWrite( led2, LOW ); break;
      case 5 : digitalWrite( led3, HIGH ); break;
      case 6 : digitalWrite( led3, LOW ); break;
      case 7 : digitalWrite( led4, HIGH ); break;
      case 8 : digitalWrite( led4, LOW ); break;
    }
  }
}
