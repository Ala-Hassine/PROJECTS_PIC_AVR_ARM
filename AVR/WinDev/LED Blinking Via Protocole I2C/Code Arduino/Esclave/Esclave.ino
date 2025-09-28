#include <Wire.h>
char data;
int led1 = 13;
int led2 = 12;
int led3 = 11;
int led4 = 10;
void setup() {
  Wire.begin(8);
  Wire.onReceive(ala);
  DDRB = B111100;
}

void loop() {
}
void ala (int HowMany)
{
  if (Wire.available() > 0)
  {
    data = Wire.read();
    {
     switch(data)
     {
      case 'A' : digitalWrite(led1, HIGH); break;
      case 'B' : digitalWrite(led1, LOW); break;
      case 'C' : digitalWrite(led2, HIGH); break;
      case 'D' : digitalWrite(led2, LOW); break;
      case 'E' : digitalWrite(led3, HIGH); break;
      case 'F' : digitalWrite(led3, LOW); break;
      case 'G' : digitalWrite(led4, HIGH); break;
      case 'H' : digitalWrite(led4, LOW); break;
     }
    }
  }
}
