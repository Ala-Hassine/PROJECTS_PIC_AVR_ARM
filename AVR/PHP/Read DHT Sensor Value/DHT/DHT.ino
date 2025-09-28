#include <DHT.h>

#define DHT_PIN   A0
#define DHT_TYPE  DHT11

DHT dht(DHT_PIN, DHT_TYPE);

void setup() 
{
  Serial.begin(9600);
  dht.begin();
}

void loop() 
{
  delay(2000);
  float humidity    = dht.readHumidity();
  float temperature = dht.readTemperature();
  if (isnan(humidity) || isnan(temperature)) 
  {
    Serial.println("ERROR : Failed To Read From DHT Sensor");
    return;
  }
  Serial.print(temperature);
  Serial.print(",");
  Serial.println(humidity);
}