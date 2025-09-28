#include <Servo.h>
Servo MyServo;
char data;

void setup()
{
  Serial.begin(9600);
  MyServo.attach(9);
}
void loop()
{
  if (Serial.available() > 0)
  {
    data = Serial.read();
    switch(data)
    {
      case 'A' : MyServo.write(0); break;
      case 'B' : MyServo.write(90); break;
      case 'C' : MyServo.write(180); break;
      case 'D' : MyServo.write(-90); break;
    }
  }
}
