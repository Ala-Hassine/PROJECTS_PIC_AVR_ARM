#include <Servo.h>
Servo myServo;
int data;

void setup()
{
  Serial.begin(9600);
  myServo.attach(9);
}

void loop()
{
  if (Serial.available() > 0)
  {
    data = Serial.read();
    myServo.write(data);
    delay(10);
  }
}
