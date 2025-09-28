const int S1 = 8;
const int S2 = 9;
const int EN = 10;
String ala;

void setup() {
  Serial.begin(9600);
  pinMode(S1, OUTPUT);
  pinMode(S2, OUTPUT);
  pinMode(EN, OUTPUT);
}

void loop() {
  if (Serial.available() > 0)
  {
    ala = Serial.readStringUntil('\n');
    Serial.println(ala);
    int val = ala.toInt();

    if (val < 1)
    {
      val = val * (-1);
      analogWrite(EN, val);
      digitalWrite(S1, HIGH);
      digitalWrite(S2, LOW);
    }
    else
    {
      analogWrite(EN, val);
      digitalWrite(S1, LOW);
      digitalWrite(S2, HIGH);
    }
  }
}
