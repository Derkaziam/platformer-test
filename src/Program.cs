using Raylib_cs;
using System.Numerics;

namespace PoliticsGame;
static class Program {
    public static void Main() {

        // Variables
        const int screenWidth = 1280;
        const int screenHeight = 720;

        const float centerX = screenWidth / 2;
        const float centerY = screenHeight / 2;

        Vector2 position = new Vector2(Raylib.GetMouseX(), Raylib.GetMouseY());
        Vector2 size = new Vector2(40, 40);

        // Initialize Window
        Raylib.InitWindow(screenWidth, screenHeight, "CountyGame");
        Raylib.SetTargetFPS(120);

        // Game Loop
        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawFPS(10, 10);
                Raylib.DrawRectangleV(position, size, Color.BLACK);
                Raylib.DrawText("Testing", centerX, centerY, 20, Color.BLACK);
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}

