int Val_1;
int Val_2;
int Val_3;

char data;

void setup() {
  Serial.begin(9600);
}

void loop() {

  if (Serial.available() > 0) {

    data = Serial.read();
    
    if (data == 'A') {
      
      int Val_1 = analogRead(A0);
      int Val_2 = analogRead(A1);
      int Val_3 = analogRead(A2);

      Serial.print(Val_1);
      Serial.print("#");
      Serial.print(Val_2);
      Serial.print("#");
      Serial.print(Val_3);
      delay(10);
      
    }
  }
}
