//library include
#include <DHT.h>

//Definimos el pin digital donde se conecta el sensor
#define DHTPIN 2

//Dependiendo del tipo de sensor
#define DHTTYPE DHT11

//Iniciamos el sensor DHT11
DHT dht(DHTPIN, DHTTYPE);

void setup() {
  //Iniciamos comunicacion seriE
  Serial.begin(9600);

  //Comenzamos el sensor DHT
  dht.begin();

}

void loop() {
  // put your main code here, to run repeatedly:

  float h, t;

  //Leemos la humedad relativa
  h = dht.readHumidity();

  //Leemos la temperatura en grados centrigrados
  t = dht.readTemperature();

  //Comprobamoss si ha habido algun error en la lectura
  if(isnan(h) || isnan(t)){
    Serial.println("Error obteniendo los datos del sensor DHT11");
    return;
  }

  //Enviar datos a C#
  Serial.print("@"); //Caracter de datos de inicio
  Serial.print(t);
  Serial.print("A");
  Serial.print(h);
  Serial.println("B");

}
