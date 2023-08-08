using Raylib_cs;
using System.Numerics;

namespace CountyGame;
static class Program {
    public static void Main() {

        // Variables
        const int screenWidth = 1280;
        const int screenHeight = 720;

        const float centerX = screenWidth / 2.0f;
        const float centerY = screenHeight / 2.0f;

        Vector2 position = new Vector2(Raylib.GetMouseX(), Raylib.GetMouseY());
        Vector2 size = new Vector2(40.0f, 40.0f);
        Color blue = new Color(0, 0, 255, 255);
        int FPS = Raylib.GetFPS();

        // Initialize Window
        Raylib.InitWindow(screenWidth, screenHeight, "CountyGame");
        Raylib.SetTargetFPS(120);

        // Game Loop
        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);
                Raylib.DrawFPS(10, 10);
                Raylib.DrawRectangleV(position, size, blue);
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}

