using System.Numerics;
using System.Reflection;
using Raylib_cs;
Raylib.InitWindow(1000,800,"Fredrik");
Raylib.SetTargetFPS(60);

Color red = new(200,10,0,255);
Vector2 lefteye = new(350,275);
Vector2 righteye = new(550,275);
Vector2 hat1 =new(100,100);
Vector2 hat2 = new(300,500);
Vector2 hat3 = new (200,400);
Vector2 snowflake = new (300,400);
Vector2[] snowflakes = new Vector2[300];
int bort = 1000;
int borti = 800;
float[] snowflakesspeeds = new float[400];


for (int i = 0; i < snowflakes.Length; i++)
{
    snowflakes[i] = new(
    Random.Shared.Next(bort),
    Random.Shared.Next(borti));
    snowflakesspeeds[i] = 3 *(float)Random.Shared.NextDouble();
}

bool showtext = false;

while(Raylib.WindowShouldClose() == false){
Raylib.BeginDrawing();
Raylib.ClearBackground(Color.Black);

for (int i = 0; i < snowflakes.Length; i++)
{
    snowflakes [i].Y += snowflakesspeeds[i];
    if (snowflakes[i].Y > 810){
        snowflakes[i].Y = -20;
    }
}
Raylib.ClearBackground(Color.Blue);
Raylib.DrawRectangle(400,500,50,60,Color.Black);
Raylib.DrawCircle(450,400,100,Color.Brown);
Raylib.DrawCircleV(lefteye,95,Color.DarkPurple);
Raylib.DrawCircleV(righteye,95,Color.DarkPurple);
Raylib.DrawTriangle(hat1,hat2,hat3,red);
Raylib.DrawCircleLines(500,400,95,red);
for (int i = 0; i < snowflakes.Length; i++)
{
  Raylib.DrawCircleV(snowflakes[i],8,Color.White);  
}
if(Raylib.IsKeyDown(KeyboardKey.B)){
Raylib.DrawText("God jul", 350,600,74,Color.Red);}

if (Raylib.IsKeyPressed(KeyboardKey.D)){
showtext = !showtext;
}
Raylib.EndDrawing();
}
 


