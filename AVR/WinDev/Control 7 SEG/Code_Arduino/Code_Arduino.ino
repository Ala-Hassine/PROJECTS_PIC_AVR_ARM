char data;
void setup()
{
  Serial.begin(9600);
  pinMode(A0, OUTPUT);
  pinMode(A1, OUTPUT);
  digitalWrite(A0, HIGH);
  digitalWrite(A1, HIGH);
  for (int j = 2 ; j < 14 ; j++) 
  {
    pinMode(j, OUTPUT);
  }
  for (int i = 2; i < 14; i++)
  {
    digitalWrite(i, HIGH);
    delay(10);
  }
}
void loop()
{
  if (Serial.available() > 0)
  {
    data = Serial.read();
    switch (data)
    {
      case '0' : digitalWrite(12, LOW);
        digitalWrite(11, LOW);
        digitalWrite(13, LOW);
        digitalWrite(10, LOW);
        digitalWrite(9, LOW);
        digitalWrite(8, LOW);
        digitalWrite(7, HIGH);
        break;
      case '1' : digitalWrite(12, LOW);
        digitalWrite(11, LOW);
        digitalWrite(13, HIGH);
        digitalWrite(10, HIGH);
        digitalWrite(9, HIGH);
        digitalWrite(8, HIGH);
        digitalWrite(7, HIGH);
        break;
      case '2' : digitalWrite(7, LOW);
        digitalWrite(8, HIGH);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
        digitalWrite(11, HIGH);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        break;
      case '3' : digitalWrite(7, LOW);
        digitalWrite(8, HIGH);
        digitalWrite(9, HIGH);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        break;
      case '4' : digitalWrite(7, LOW);
        digitalWrite(8, LOW);
        digitalWrite(9, HIGH);
        digitalWrite(10, HIGH);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, HIGH);
        break;
      case '5' : digitalWrite(7, LOW);
        digitalWrite(8, LOW);
        digitalWrite(9, HIGH);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, HIGH);
        digitalWrite(13, LOW);
        break;
      case '6' : digitalWrite(7, LOW);
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, HIGH);
        digitalWrite(13, LOW);
        break;
      case '7' : digitalWrite(7, HIGH);
        digitalWrite(8, HIGH);
        digitalWrite(9, HIGH);
        digitalWrite(10, HIGH);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        break;
      case '8' : digitalWrite(7, LOW);
        digitalWrite(8, LOW);
        digitalWrite(9, LOW);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        break;
      case '9' : digitalWrite(7, LOW);
        digitalWrite(8, LOW);
        digitalWrite(9, HIGH);
        digitalWrite(10, LOW);
        digitalWrite(11, LOW);
        digitalWrite(12, LOW);
        digitalWrite(13, LOW);
        break;
      case 'A' : digitalWrite(A1, LOW); break;
      case 'B' : digitalWrite(A0, LOW); break;
      case 'C' : digitalWrite(2, LOW); break;
      case 'D' : digitalWrite(3, LOW); break;
      case 'E' : digitalWrite(4, LOW); break;
      case 'F' : digitalWrite(5, LOW); break;
      case 'G' : digitalWrite(6, LOW); break;
      default : digitalWrite(A0, HIGH);
        digitalWrite(A1, HIGH);
        digitalWrite(2, HIGH);
        digitalWrite(3, HIGH);
        digitalWrite(4, HIGH);
        digitalWrite(5, HIGH);
        digitalWrite(6, HIGH);
        digitalWrite(7, HIGH);
        digitalWrite(8, HIGH);
        digitalWrite(9, HIGH);
        digitalWrite(10, HIGH);
        digitalWrite(11, HIGH);
        digitalWrite(12, HIGH);
        digitalWrite(13, HIGH);
        break;
    }
  }
}
