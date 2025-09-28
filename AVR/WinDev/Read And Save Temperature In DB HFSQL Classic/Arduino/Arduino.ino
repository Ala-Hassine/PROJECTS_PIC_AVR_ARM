#include <LiquidCrystal.h>

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);

float Celsius1 , Celsius2 , Celsius3 ;
char my;
int led1 = 10;
int led2 = 9;
int led3 = 8;

void setup() {
  lcd.begin(20, 4);
  Serial.begin(9600);

  pinMode(led1,OUTPUT);
  pinMode(led2,OUTPUT);
  pinMode(led3,OUTPUT);
  
  lcd.setCursor(2, 0);
  lcd.print("Stage Technicien");
  
  lcd.setCursor(1, 1);
  lcd.print("Analog 1 : ");
  lcd.setCursor(19,1);
  lcd.print("C");
  
  lcd.setCursor(1, 2);
  lcd.print("Analog 2 : ");
  lcd.setCursor(19,2);
  lcd.print("C");
  
  lcd.setCursor(1, 3);
  lcd.print("Analog 3 : ");
  lcd.setCursor(19,3);
  lcd.print("C");
}

void loop() {
  if(Serial.available() > 0)
  {
    my = Serial.read();
    TempFunc();
    LcdFunc();
    LedFunc();
    SerialFunc();
  }  
}

void TempFunc()
{
 int val1 = analogRead(A0);
 int val2 = analogRead(A1);
 int val3 = analogRead(A2);
 
 Celsius1 = (val1 * 0.0049) * 100;
 Celsius2 = (val2 * 0.0049) * 100;
 Celsius3 = (val3 * 0.0049) * 100;
}

void LcdFunc()
{
 lcd.setCursor(12, 1);
 lcd.print(Celsius1);
 lcd.setCursor(12, 2);
 lcd.print(Celsius2);
 lcd.setCursor(12, 3);
 lcd.print(Celsius3);
}

void LedFunc()
{
  //All LED ARE OFF
  if ((Celsius1 < 70) && (Celsius2 < 70) && (Celsius3 < 70))
  {
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
  }

   //ONE LED IS ON
  else if ((Celsius1 >= 70) && (Celsius2 < 70) && (Celsius3 < 70))
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2,LOW);
    digitalWrite(led3,LOW);
  }
  else if ((Celsius1 < 70) && (Celsius2 >= 70) && (Celsius3 < 70))
  {
    digitalWrite(led1,LOW);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,LOW);
  }
  else if ((Celsius1 < 70) && (Celsius2 < 70) && (Celsius3 >= 70))
  {
    digitalWrite(led1,LOW);
    digitalWrite(led2,LOW);
    digitalWrite(led3,HIGH);
  }

  //TWO LED ARE ON
  else if ((Celsius1 >= 70) && (Celsius2  >= 70) && (Celsius3 < 70))
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,LOW);
  }
  else if ((Celsius1 >= 70) && (Celsius2 < 70) && (Celsius3 >= 70))
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2,LOW);
    digitalWrite(led3,HIGH);
  }
  else if ((Celsius1 < 70) && (Celsius2 >= 70) && (Celsius3 >= 70))
  {
    digitalWrite(led1,LOW);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
  }

  //ALL LED ARE ON
  else
  {
    digitalWrite(led1,HIGH);
    digitalWrite(led2,HIGH);
    digitalWrite(led3,HIGH);
  }
}

void SerialFunc()
{
  if(my == 'A')
  {
 Serial.print(Celsius1);
 Serial.print("#");
 Serial.print(Celsius2);
 Serial.print("#");
 Serial.println(Celsius3);
  }
 delay(10);
}
