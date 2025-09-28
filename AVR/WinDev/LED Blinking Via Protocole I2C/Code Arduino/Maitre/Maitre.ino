#include <Wire.h>
void setup() 
{
  Wire.begin();
  Serial.begin(9600);
}
void loop() {
  if (Serial.available() > 0)
  {
    char c = Serial.read();
    Wire.beginTransmission(8);
    Wire.write(c);
    Wire.endTransmission();
    Serial.println(c);
    delay(15);
  }
}

