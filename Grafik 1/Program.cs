using System.Numerics;
using Raylib_cs;
Raylib.InitWindow(1000,800,"Fredrik");
Raylib.SetTargetFPS(60);

Color red = new(200,10,0,255);
Vector2 lefteye = new(350,275);
Vector2 righteye = new(550,475);
Vector2 hat1 =new(100,100);
Vector2 hat2 = new(50,40);
Vector2 hat3 = new (200,600);


while(Raylib.WindowShouldClose() == false){
Raylib.BeginDrawing();
Raylib.ClearBackground(Color.Blue);
Raylib.DrawRectangle(400,500,50,60,Color.Black);
Raylib.DrawCircle(500,400,100,Color.Brown);
Raylib.DrawCircleV(lefteye,95,Color.DarkPurple);
Raylib.DrawCircleV(righteye,95,Color.DarkPurple);
Raylib.DrawTriangle(hat1,hat2,hat3,red);
Raylib.DrawCircleLines(500,400,95,red);
Raylib.EndDrawing();
}