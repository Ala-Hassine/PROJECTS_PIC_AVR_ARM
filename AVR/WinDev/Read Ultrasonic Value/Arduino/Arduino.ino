const int pingPin = 3; // Trigger Pin of Ultrasonic Sensor
const int echoPin = 2; // Echo Pin of Ultrasonic Sensor
const int led = 13;
char data;

void setup()
{
  Serial.begin(9600); // Starting Serial Terminal
  pinMode(led, OUTPUT);
}

void loop()
{
  if (Serial.available() > 0)
  {
    data = Serial.read();
    if (data == 'A') {
      long duration, inches, cm;
      pinMode(pingPin, OUTPUT);
      digitalWrite(pingPin, LOW);
      delayMicroseconds(2);
      digitalWrite(pingPin, HIGH);
      delayMicroseconds(10);
      digitalWrite(pingPin, LOW);

      pinMode(echoPin, INPUT);
      duration = pulseIn(echoPin, HIGH);
      inches = microsecondsToInches(duration);
      cm = microsecondsToCentimeters(duration);

      if (inches > 219) {
        digitalWrite(led, HIGH);
        //Serial.print("LED ON");
      }
      else {
        digitalWrite(led, LOW);
        //Serial.print("LED OFF");
      }

      //Serial.print("#");
      Serial.print(inches);
      Serial.print("#");
      Serial.println(cm);
      delay(10);
    }
  }
}

long microsecondsToInches(long microseconds)
{
  return microseconds / 74 / 2;
}

long microsecondsToCentimeters(long microseconds)
{
  return microseconds / 29 / 2;
}
