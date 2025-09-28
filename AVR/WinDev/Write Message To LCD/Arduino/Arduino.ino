#include<LiquidCrystal.h>
LiquidCrystal lcd(12, 10, 5, 4, 3, 2);

char data;
int col = 0;
int row = 0;

void setup() {
  Serial.begin(9600);
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
  lcd.print("EMBEDDED SYSTEM");
  delay(500);
  lcd.clear();
}

void loop() {
  
  if (Serial.available() > 0)
  {
    
    data = Serial.read();
    lcd.setCursor(col, row);
    lcd.print(data);
    col++;

    if (col > 15) {
      row++;
      col = 0;
      lcd.print(data);
    }
    
  }
  
  //   if (row == 1 && col >= 15) {
  //      lcd.clear();
  //      col = 0;
  //      row = 0;
  //    }
  
  if (data == '*') {
    lcd.clear();
    col = 0;
    row = 0;
  }
  
}
