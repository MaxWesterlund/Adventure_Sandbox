using Raylib_cs;

public class Draw {
    int fontSize = 20;
    int lineSpacing = 20;
    int lineMargin = 5;
    int optionMargin = 20;
    
    public void DrawEverything() {
        Raylib.BeginDrawing();
    
        Raylib.ClearBackground(Color.BLACK);

        Raylib.DrawText(GameManager.CurrentLine.CurrentText, lineMargin, 0, fontSize, Color.WHITE);
        
        if (GameManager.CurrentLine.IsDone) {
            int optionSpacing = 0;
            foreach (Option o in GameManager.CurrentOptions) {
                string text = o.IsSelected ? "< " + o.Description + " >" : o.Description;
                Raylib.DrawText(text, lineMargin + optionSpacing, lineSpacing, fontSize, Color.WHITE);
                optionSpacing += Raylib.MeasureText(text, fontSize) + optionMargin;
            }   
        }

        Raylib.EndDrawing();
    }

}