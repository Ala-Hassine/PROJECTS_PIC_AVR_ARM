char data;
void setup()
{
  Serial.begin(9600);
  pinMode(7, OUTPUT);
  pinMode(8, OUTPUT);
  pinMode(9, OUTPUT);
  pinMode(10, OUTPUT);
  pinMode(11, OUTPUT);
  pinMode(12, OUTPUT);
  pinMode(13, OUTPUT);
  for (int i = 7; i < 14; i++)
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
        case 'A' : digitalWrite(7, LOW); break;
        case 'B' : digitalWrite(8, LOW); break;
        case 'C' : digitalWrite(9, LOW); break;
        case 'D' : digitalWrite(10, LOW); break;
        case 'E' : digitalWrite(11, LOW); break;
        case 'F' : digitalWrite(12, LOW); break;
        case 'G' : digitalWrite(13, LOW); break;
      default : digitalWrite(7, HIGH);
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
