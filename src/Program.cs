using Raylib_cs;
using System.Numerics;
using Platformer;

namespace Platformer;
static class Program {
    public static void Main() {

        // Variables
        Vector2 position = new Vector2(Raylib.GetMouseX(), Raylib.GetMouseY());
        Vector2 size = new Vector2(40, 40);

        // Initialize Window
        Raylib.InitWindow(Constants.screenWidth, Constants.screenHeight, "CountyGame");
        Raylib.SetTargetFPS(60);

        // Game Loop
        while (!Raylib.WindowShouldClose()) {
            Raylib.BeginDrawing();
                Menu.MainMenu.CreateMenu();
            Raylib.EndDrawing();
        }
        
        Raylib.CloseWindow();
    }
}

