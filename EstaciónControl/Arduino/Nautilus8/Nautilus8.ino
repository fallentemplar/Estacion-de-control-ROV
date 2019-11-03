#include <Servo.h>

 int luces=A0; 
 int camx=8; //Gimbal
 int camy=9;
 int motor1 = 2; //frontal
 int motor2 = 3;
 int motor3 = 4; //trasero
 int motor4 = 5;
 int motor5= 6;  //arriba/abajo
 int motor6 = 7;
 int motor7 = 10;
 int motor8 = 11;

 int x1,x2,x3,x4,x5,x6,x7,x8; //variables
 
 Servo luz;
 Servo x;
 Servo y;
 Servo m1;
 Servo m2;
 Servo m3;
 Servo m4;
 Servo m5;
 Servo m6;
 Servo m7;
 Servo m8;

  // Numero de datos que vamos a leer
  const int numberOfPieces = 8;

  String pieces[numberOfPieces];
  String input = "";
  int counter = 0;
  int lastIndex = 0;

void setup()
{
    Serial.begin(115200);
    luz.attach(luces);
    x.attach(camx);
    y.attach(camy);
    m1.attach(motor1);
    m2.attach(motor2);
    m3.attach(motor3);
    m4.attach(motor4);
    m5.attach(motor5);
    m6.attach(motor6);
    m7.attach(motor7);
    m8.attach(motor8);
}

void loop()
{
  if (Serial.available() > 0)
  {
    char ch = Serial.read();
    if (ch == '\n')              //Inicia el proceso de separación de la cadena de String a partir de cada salto de línea
    
    {
      for (int i = 0; i < input.length(); i++)
      {
        if (input.substring(i, i+1) == ",")   //Se separa la cadena por cada coma 
        {
          pieces[counter] = input.substring(lastIndex, i);
          lastIndex = i + 1;
          counter++;
        }
        if (i == input.length() - 1)
        {
          pieces[counter] = input.substring(lastIndex, i);
        }
      } 
      input = "";
      counter = 0;
      lastIndex = 0;
    }
    else
    {
      input += ch;
    }
  }
  x1=pieces[0].toInt();    //cada vector tiene una posición y se convierte a entero
  x2=pieces[1].toInt();
  x3=pieces[2].toInt();
  x4=pieces[3].toInt();
  x5=pieces[4].toInt();
  x6=pieces[5].toInt();
  x7=pieces[6].toInt();
  x8=pieces[7].toInt();
  
  int lamp=1;
  int jy2=x2;
  jy2=map(jy2, 60, 0, 65, 115);
  int jx2=x3;
  jx2=map(jx2,60,0,60,120);
  int rb=x4;
  int lb=x5;
  int jy1=x6;
  jy1=map(jy1, 0, 60, 1200, 1800);
  int jx1=x7;
  jx1=map(jx1, 0, 60, 1200, 1800);
  int RtLt=((x8-30)+150)*10;
  
  camara(jx2,jy2); 
  profundidad(RtLt,RtLt,RtLt,RtLt);

  if(x1!=lamp)
  {
    lamp=x1;
    int l=((300*x1)+1100);
    lampara(l);
  }
  
  if (rb==0&&lb==0)
  {
    if((jy1<1500 && jx1==1500)||(jy1>1500 && jx1==1500))
    {          //  adelante/atras
      mover(jy1,jy1,jy1,jy1);                                          
    }
    
    else if((jy1==1500 && jx1<1500)||(jy1==1500 && jx1>1500))
    {    // izquierda derecha
      int x;
      x=3000-jx1;
      mover(x,jx1,jx1,x);
    }
    
  }
  else  if (rb==1&&lb==0)
  {
    mover(1600,1400,1600,1400);
    //giro derecha
  }
  else  if (rb==0&&lb==1)
  {
    mover(1400,1600,1400,1600);
    //giro izquierda
  }
}

void profundidad(int p1,int p2,int p3,int p4){
  m5.writeMicroseconds(p1);
  m6.writeMicroseconds(p2);
  m7.writeMicroseconds(p3);
  m8.writeMicroseconds(p4);
  //Serial.println("profundidad");
 }

void lampara(int p1){
  luz.writeMicroseconds(p1);
  //Serial.println("luz");
}

void camara(int p1,int p2){
      x.write(p1);
      y.write(p2);
      //Serial.println("camara \n");
}

void mover(int p1,int p2,int p3,int p4){
      m1.writeMicroseconds(p1);
      m2.writeMicroseconds(p2);
      m3.writeMicroseconds(p3);
      m4.writeMicroseconds(p4);
      //Serial.println("mover");
}
