#define NUMBER_OF_SHIFT_CHIPS   2
#define DATA_WIDTH   NUMBER_OF_SHIFT_CHIPS * 8 // * 4 : 8 Pins ; * 8 : 16 Pins
#define TotalIC 2
#define TotalICPins TotalIC * 8

int LoadPin    = 8;
int EnablePin  = 9;
int DataPin    = 11;
int ClockPin   = 12;

char data;

int RCLK = 5;
int SER = 6;
int SRCLK = 7;

unsigned long pinValues;
unsigned long oldPinValues;
boolean Data[TotalICPins];

void setup()
{
  Serial.begin(9600);

  pinMode(LoadPin, OUTPUT);
  pinMode(EnablePin, OUTPUT);
  pinMode(ClockPin, OUTPUT);
  pinMode(DataPin, INPUT);

  digitalWrite(ClockPin, LOW);
  digitalWrite(LoadPin, HIGH);
  pinMode(SER, OUTPUT);
  pinMode(RCLK, OUTPUT);
  pinMode(SRCLK, OUTPUT);

  ClearBuffer();

  pinValues = read_shift_regs();
  print_byte();
  oldPinValues = pinValues;
}

void loop()
{
 // if (Serial.available() > 0)
 // {
    //data = Serial.read();
   // if (data == 'A') {
      pinValues = read_shift_regs();
      if (pinValues != oldPinValues)
      {
        print_byte();
        oldPinValues = pinValues;
      }
   // }
  //}
}

unsigned long read_shift_regs()
{
  long bitVal;
  unsigned long bytesVal = 0;

  digitalWrite(EnablePin, HIGH);
  digitalWrite(LoadPin, LOW);
  delayMicroseconds(5);
  digitalWrite(LoadPin, HIGH);
  digitalWrite(EnablePin, LOW);

  for (int i = 0; i < DATA_WIDTH; i++)
  {
    bitVal = digitalRead(DataPin);
    bytesVal |= (bitVal << ((DATA_WIDTH - 1) - i));

    digitalWrite(ClockPin, HIGH);
    delayMicroseconds(5);
    digitalWrite(ClockPin, LOW);
  }
  return (bytesVal);
}

void print_byte() {
  byte i;
  for (byte i = 0; i <= DATA_WIDTH - 1; i++)
  {
    Serial.print(pinValues >> i & 1, BIN);
    Data[i] = pinValues >> i & 1, BIN;
    UpdateData();
    Serial.print('#');
  }
}
