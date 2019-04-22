long randNumber;

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);

  randomSeed(analogRead(A0));
randNumber =random(1500, 2500);
 Serial.println(String(randNumber));
  
}

void loop() {
 
 

 
}
