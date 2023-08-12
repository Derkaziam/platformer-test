using Raylib_cs;
using Platformer;
using System.Numerics;

namespace Platformer.Menu;
public class MainMenu {
    private void Title() {
        
    }

    public static void CreateMenu() {
        int X               = Constants.centerX;
        int Y               = Constants.centerY;
        Vector2 position    = new Vector2(Raylib.GetMouseX(), Raylib.GetMouseY());
        Vector2 recSize     = new Vector2(40, 40);
        
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawRectangleV(pos, size, Color.BLUE);
        Raylib.DrawText("Politics", X, Y, 20, Color.BLACK);
        Raylib.DrawFPS(10, 10);
    }
}