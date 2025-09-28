#include <Servo.h>
Servo MyServo;
int data;
void setup()
{
  Serial.begin(9600);
  MyServo.attach(13);
}
void loop()
{
  if (Serial.available() > 0)
  {
    data = Serial.parseInt();
    if (data > 0 && data < 180)
    {
      MyServo.write(data);
    }
  }
}
