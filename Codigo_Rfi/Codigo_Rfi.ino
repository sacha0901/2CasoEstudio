#include <SPI.h>                       // Librería para la comunicación SPI
#include <MFRC522.h>                   // Librería para el módulo RFID
#include <Wire.h>                      // Librería para la comunicación I2C
#include <LiquidCrystal_I2C.h>         // Librería para la pantalla LCD I2C
#include <Servo.h>                     // Librería para controlar el servomotor

#define SS_PIN 10                      // Pin de selección de esclavo para el módulo RFID
#define RST_PIN 9                      // Pin de reset para el módulo RFID
MFRC522 mfrc522(SS_PIN, RST_PIN);      // Crear una instancia del objeto MFRC522

LiquidCrystal_I2C lcd(0x27, 20, 4);    // Crear una instancia del objeto LCD con la dirección I2C y tamaño 20x4

Servo myServo;                        // Crear una instancia del objeto Servo
int servoPin = 6;                     // Pin para el servomotor

int ledPins[] = {2, 3, 4, 1};         // Definir los pines de los LEDs
int ledVerde = 7;                     // Definir el pin del LED verde
int ledRojo = 8;                      // Definir el pin del LED rojo

int buzzerPin = 5;                   // Definir el pin del buzzer

int capacidad_maxima = 4;             // Definir la capacidad máxima del laboratorio
int capacidad_actual = 0;             // Definir la capacidad actual del laboratorio (inicialmente 0)

String uids[] = {                     // Array de UIDs de las tarjetas RFID permitidas
  "F1 3C AF 29",  // EQ1
  "EE 27 A1 59",  // EQ2
  "4A 67 31 29",  // EQ3
  "25 0E 86 11"   // Coordinador
};

String nombres[] = {                  // Array de nombres correspondientes a las tarjetas RFID
  "EQ1",
  "EQ2",
  "EQ3",
  "Coordinador"
};

bool estado_integrantes[4] = {false, false, false, false};  // Estado de los integrantes dentro del laboratorio (todos fuera inicialmente)

void setup() {
  Serial.begin(9600);                  // Inicializar la comunicación serie a 9600 baudios
  SPI.begin();                         // Inicializar la comunicación SPI
  mfrc522.PCD_Init();                  // Inicializar el módulo RFID
  lcd.init();                          // Inicializar la pantalla LCD
  lcd.backlight();                     // Encender la luz de fondo de la pantalla LCD
  myServo.attach(servoPin);            // Adjuntar el servomotor al pin especificado
  myServo.write(0);                    // Posicionar el servomotor en la posición inicial (puerta cerrada)

  for (int i = 0; i < 4; i++) {        // Configurar los pines de los LEDs como salidas y apagarlos inicialmente
    pinMode(ledPins[i], OUTPUT);
    digitalWrite(ledPins[i], LOW);
  }
  
  pinMode(ledVerde, OUTPUT);           // Configurar el pin del LED verde como salida
  pinMode(ledRojo, OUTPUT);            // Configurar el pin del LED rojo como salida
  digitalWrite(ledVerde, LOW);         // Apagar el LED verde inicialmente
  digitalWrite(ledRojo, LOW);          // Apagar el LED rojo inicialmente

  pinMode(buzzerPin, OUTPUT);          // Configurar el pin del buzzer como salida
  digitalWrite(buzzerPin, LOW);        // Apagar el buzzer inicialmente

  mostrarEstadoLaboratorio();          // Mostrar el estado inicial del laboratorio en la pantalla LCD
}

void loop() {
  if (!mfrc522.PICC_IsNewCardPresent() || !mfrc522.PICC_ReadCardSerial()) {
    return;  // Si no hay una nueva tarjeta presente, salir de la función
  }

  String uid = "";                      // Variable para almacenar el UID leído
  for (byte i = 0; i < mfrc522.uid.size; i++) {  // Leer el UID de la tarjeta
    uid += String(mfrc522.uid.uidByte[i] < 0x10 ? "0" : "");
    uid += String(mfrc522.uid.uidByte[i], HEX);
    if (i < mfrc522.uid.size - 1) uid += " ";
  }
  uid.toUpperCase();                    // Convertir el UID a mayúsculas
  //Serial.println("UID leído: " + uid);  // Imprimir el UID leído en el monitor serie

  int indice = verificarUID(uid);       // Verificar si el UID pertenece a un usuario registrado

  if (indice != -1) {                   // Si el UID es de un usuario registrado
    if (estado_integrantes[indice]) {   // Si el usuario está dentro del laboratorio
      estado_integrantes[indice] = false;  // Marcar al usuario como fuera del laboratorio
      capacidad_actual--;               // Reducir la capacidad actual
      digitalWrite(ledPins[indice], LOW);  // Apagar el LED correspondiente
      Serial.print("S");         // Enviar mensaje de salida por serial
      Serial.println(nombres[indice]);  // Incluir el nombre del usuario
    } else {                            // Si el usuario está fuera del laboratorio
      estado_integrantes[indice] = true;   // Marcar al usuario como dentro del laboratorio
      capacidad_actual++;               // Aumentar la capacidad actual
      digitalWrite(ledPins[indice], HIGH); // Encender el LED correspondiente
      Serial.print("E");        // Enviar mensaje de entrada por serial
      Serial.println(nombres[indice]);  // Incluir el nombre del usuario
    }

    mostrarEstadoLaboratorio();         // Actualizar y mostrar el estado del laboratorio

    digitalWrite(ledVerde, HIGH);       // Encender el LED verde
    digitalWrite(ledRojo, LOW);         // Apagar el LED rojo
    digitalWrite(buzzerPin, HIGH);      // Encender el buzzer
    delay(500);                         // Mantener el buzzer encendido por 0.5 segundos
    digitalWrite(buzzerPin, LOW);       // Apagar el buzzer

    lcd.clear();                        // Limpiar la pantalla LCD
    lcd.setCursor(0, 0);                // Posicionar el cursor en la primera fila
    lcd.print("Acceso permitido:");     // Mostrar mensaje de acceso permitido
    lcd.setCursor(0, 1);                // Posicionar el cursor en la segunda fila
    lcd.print(nombres[indice]);         // Mostrar el nombre del usuario
    delay(1000);                        // Esperar 1 segundos

    myServo.write(90);                  // Girar el servomotor para abrir la puerta
    delay(3000);                        // Mantener la puerta abierta por 3 segundos
    myServo.write(0);                   // Girar el servomotor para cerrar la puerta
  } else {                              // Si el UID no es de un usuario registrado
    digitalWrite(ledVerde, LOW);        // Apagar el LED verde
    digitalWrite(ledRojo, HIGH);        // Encender el LED rojo
    digitalWrite(buzzerPin, HIGH);      // Encender el buzzer
    delay(1000);                        // Mantener el buzzer encendido por 1 segundo
    digitalWrite(buzzerPin, LOW);       // Apagar el buzzer

    lcd.clear();                        // Limpiar la pantalla LCD
    lcd.setCursor(0, 0);                // Posicionar el cursor en la primera fila
    lcd.print("Acceso denegado");       // Mostrar mensaje de acceso denegado
    delay(2000);                        // Esperar 2 segundos
  }

  digitalWrite(ledVerde, LOW);          // Apagar el LED verde después de mostrar el mensaje
  digitalWrite(ledRojo, LOW);           // Apagar el LED rojo después de mostrar el mensaje

  mostrarEstadoLaboratorio();           // Volver a mostrar el estado del laboratorio
}

int verificarUID(String uid) {           // Función para verificar si el UID pertenece a un usuario registrado
  for (int i = 0; i < 4; i++) {         // Iterar a través de los UIDs registrados
    //Serial.println("Comparando con UID almacenado: " + uids[i]); // Imprimir el UID almacenado en el monitor serie
    if (uid.equals(uids[i])) {          // Si el UID coincide
      return i;                         // Devolver el índice del usuario
    }
  }
  return -1;                            // Si no hay coincidencia, devolver -1
}

void mostrarEstadoLaboratorio() {        // Función para mostrar el estado del laboratorio en la pantalla LCD
  lcd.clear();                          // Limpiar la pantalla LCD
  lcd.setCursor(0, 0);                  // Posicionar el cursor en la primera fila
  lcd.print("Capacidad: ");             // Mostrar el texto "Capacidad: "
  lcd.print(capacidad_actual);          // Mostrar la capacidad actual
  lcd.print("/");                       // Mostrar el separador "/"
  lcd.print(capacidad_maxima);          // Mostrar la capacidad máxima
  
  if (capacidad_actual == 0) {          // Si la capacidad actual es 0
    lcd.setCursor(0, 1);                // Posicionar el cursor en la segunda fila
    lcd.print("Laboratorio vacio");     // Mostrar el mensaje "Laboratorio vacío"
  } else {                              // Si hay usuarios dentro del laboratorio
    lcd.setCursor(0, 1);                // Posicionar el cursor en la segunda fila
    lcd.print("Dentro:");               // Mostrar el texto "Dentro:"
    int fila = 1;                       // Variable para la fila actual (empezando en la segunda fila)
    int columna = 7;                    // Variable para la columna actual (después del texto "Dentro:")
    for (int i = 0; i < 4; i++) {       // Iterar a través de los usuarios
      if (estado_integrantes[i]) {      // Si el usuario está dentro del laboratorio
        if (columna + nombres[i].length() > 20) {  // Si el nombre no cabe en la fila actual
          fila++;                       // Mover a la siguiente fila
          columna = 0;                  // Reiniciar la columna
          if (fila > 3) break;          // Si no hay más espacio en la pantalla, salir del bucle
        }
        lcd.setCursor(columna, fila);   // Posicionar el cursor en la columna y fila actuales
        lcd.print(nombres[i]);          // Mostrar el nombre del usuario
        columna += nombres[i].length() + 1; // Avanzar la columna para el siguiente nombre
      }
    }
  }
}
