

#define MotorIN1 7
#define MotorIN2 8
#define MotorIN3 10
#define MotorIN4 11

#define MotorENA 6
#define MotorENB 9

// #define Line1
// #define Line2
// #define Line3
// #define Line4
// #define Line5

uint8_t lspeed = 255;
uint8_t rspeed = 255;


void setup() 
{
  pinMode(MotorIN1, OUTPUT);
  pinMode(MotorIN2, OUTPUT);
  pinMode(MotorIN3, OUTPUT);
  pinMode(MotorIN4, OUTPUT);

  pinMode(MotorENA, OUTPUT);
  pinMode(MotorENB, OUTPUT);
}

void loop() 
{
  digitalWrite(MotorIN1, HIGH);
  digitalWrite(MotorIN2, LOW);
  analogWrite(MotorENA, 255);

  digitalWrite(MotorIN3, HIGH);
  digitalWrite(MotorIN4, LOW);
  analogWrite(MotorENB, 255);
}
