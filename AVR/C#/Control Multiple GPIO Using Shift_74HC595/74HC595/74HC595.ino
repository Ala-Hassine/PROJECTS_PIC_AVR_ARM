// Pin ST_CP >>> 74HC595
const int latchPin = 5;
// Pin SH_CP >>> 74HC595
const int clockPin = 7;
// Pin DS >>> 74HC595
const int dataPin = 6;

void setup() {
  pinMode(latchPin, OUTPUT);
  pinMode(dataPin, OUTPUT);
  pinMode(clockPin, OUTPUT);
  Serial.begin(9600);
  Serial.println("reset");
}

void loop() {
  if (Serial.available() > 0) {
    ////// ASCII '0' through '9' characters are
    ////// represented by the values 48 through 57.
    ////// so if the user types a number from 0 through 9 in ASCII,
    ////// you can subtract 48 to get the actual value:
    int data = Serial.read() - 48;
    registerWrite(data, HIGH);
  }
}
////// This method sends bits to the shift register:
void registerWrite(int whichPin, int whichState) {
  ////// the bits you want to send
  byte dataToSend = 0;
  ////// turn off the output so the pins don't light up
  ////// while you're shifting bits:
  digitalWrite(latchPin, LOW);
  ////// turn on the next highest bit in bitsToSend:
  bitWrite(dataToSend, whichPin, whichState);
  ////// shift the bits out:
  shiftOut(dataPin, clockPin, MSBFIRST, dataToSend);
  ////// turn on the output so the LEDs can light up:
  digitalWrite(latchPin, HIGH);
}
