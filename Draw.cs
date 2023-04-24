using Raylib_cs;

public class Draw {
    public void DrawEverything() {
        Raylib.BeginDrawing();
    
        Raylib.ClearBackground(Color.BLACK);

        Raylib.DrawText(GameManager.CurrentLine.CurrentText, 0, 0, 20, Color.WHITE);

        Raylib.EndDrawing();
    }

}