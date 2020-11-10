using System;
using Raylib_cs;

namespace Kollisioner
{
  class Program
  {
    static void Main(string[] args)
    {

      Raylib.InitWindow(800, 600, "Kollisioner");
      Raylib.SetTargetFPS(60);

      Rectangle first = new Rectangle(10, 10, 50, 50);

      Rectangle second = new Rectangle(35, 35, 50, 50);

      Color semiTransparent = new Color(255, 0, 0, 128);


      while (!Raylib.WindowShouldClose())
      {

        first.x += 0.5f;


        Raylib.BeginDrawing();

        Raylib.ClearBackground(Color.SKYBLUE);

        Raylib.DrawRectangleRec(first, semiTransparent);
        Raylib.DrawRectangleRec(second, semiTransparent);

        if (Raylib.CheckCollisionRecs(first, second))
        {
          Raylib.DrawText("YES", 100, 100, 64, Color.BLACK);
        }

        Raylib.EndDrawing();
      }

    }
  }
}
