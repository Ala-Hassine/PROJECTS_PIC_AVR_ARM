int val = 0;
int temp = 0;

void setup() {
  Serial.begin(9600);
}

void loop() {
  Temperature();
  Serial.println(temp);
}

void Temperature()
{
  val = analogRead(A0);
  temp = (val * 0.0049) * 100;
}
