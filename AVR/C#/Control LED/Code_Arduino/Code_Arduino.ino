const int led = 13;
char data;
void setup() {
  Serial.begin(9600);
  pinMode(led, OUTPUT);
}
void loop() {
  if (Serial.available() > 0)
  {
    data = Serial.read();
  }
  switch (data)
  {
    case 'A' : digitalWrite(led,HIGH);break;
    case 'B' : digitalWrite(led,LOW);break;
  }
}
