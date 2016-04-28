#include <Wire.h>
#include <Adafruit_BMP085.h>
#include "I2Cdev.h"
#include "MPU9150Lib.h"
#include "CalLib.h"
#include <dmpKey.h>
#include <dmpmap.h>
#include <inv_mpu.h>
#include <inv_mpu_dmp_motion_driver.h>
#include <EEPROM.h>

Adafruit_BMP085 bmp;
#define  DEVICE_TO_USE    0
MPU9150Lib MPU; 
#define MPU_UPDATE_RATE  (20)
#define MAG_UPDATE_RATE  (10)  
#define  MPU_MAG_MIX_GYRO_ONLY          0                   // just use gyro yaw
#define  MPU_MAG_MIX_MAG_ONLY           1                   // just use magnetometer and no gyro yaw
#define  MPU_MAG_MIX_GYRO_AND_MAG       10                  // a good mix value 
#define  MPU_MAG_MIX_GYRO_AND_SOME_MAG  50 
#define MPU_LPF_RATE   40
#define  SERIAL_PORT_SPEED  9600
#define del 50
void read(void);
char x[500];
void setup() {
  Serial.begin(SERIAL_PORT_SPEED);
  pinMode(10, INPUT); // Setup for leads off detection LO +
  pinMode(11, INPUT); // Setup for leads off detection LO -
  Wire.begin();
  MPU.selectDevice(DEVICE_TO_USE);                        // only really necessary if using device 1
  MPU.init(MPU_UPDATE_RATE, MPU_MAG_MIX_GYRO_AND_MAG, MAG_UPDATE_RATE, MPU_LPF_RATE);
  if (!bmp.begin()) {
	Serial.println("Could not find a valid BMP085 sensor, check wiring!");
	while (1) {}
  }
}
  
void loop() {
    if (MPU.read())
    {                                        // get the latest data if ready yet
    Serial.print(',');
    delay(del);
    Serial.print('R');
    delay(del);
    Serial.print(MPU.m_dmpEulerPose[0]); //Serial.print(",");
    delay(del);
    Serial.print(',');
    Serial.println(' ');
    delay(del);
    Serial.print(',');
    delay(del);
    Serial.print('Y');
    delay(del);
    Serial.print(MPU.m_dmpEulerPose[1]); //Serial.print(",");
    delay(del);
    Serial.print(',');
    Serial.println(' ');
    delay(del);
    Serial.print(',');
    delay(del);
    Serial.print('B');
    delay(del);
    Serial.print(MPU.m_dmpEulerPose[2]); //Serial.println(",");
    }
    delay(del);
    read();
    Serial.print(',');
    Serial.println(' ');
    delay(del);
    Serial.print(',');
    delay(del);
    Serial.print('T');
    delay(del);
    //Serial.print(bmp.readTemperature());
    Serial.print("100");
    delay(del);
    Serial.print(',');
    Serial.println(' ');
    delay(del);
    Serial.print(',');
    delay(del);
    Serial.print('P');
    delay(del);
    Serial.print(bmp.readPressure());
    delay(del);
    Serial.print(',');
    Serial.println(' ');
    delay(del);
    Serial.print(',');
    delay(del);
     Serial.print('H');
    delay(del);
    read();
    if((digitalRead(10) == 1)||(digitalRead(11) == 1))
    {
    Serial.println('!');
    }
    else{
    // send the value of analog input 0:
      Serial.println(analogRead(A0));
    }
    read();
    delay(del);
}

void read(void)
{
  int i = 0;
  char amr =0;
  char fiza = 0;
  if(Serial.available())
  {
    while(1){
    x[i] = Serial.read();
    i++;
    if(x[1] == ':') // send to fiza
    {
      x[1] = ';';
      fiza = 1;
    }
    else if(x[1] == ';') // send to amr
    {
      x[1] = ';';
      amr = 1;
    }
    Serial.print(x[i]);
     if( amr && x[i]==',')
     {
        Serial.print(',');
        return;
     }
     else if( fiza && x[i]== ',')
      {
       Serial.println(" ");
        return;
      }
    }}
}

