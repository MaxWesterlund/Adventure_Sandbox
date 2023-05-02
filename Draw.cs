using Raylib_cs;
using System.Numerics;
using System;

public class Draw {
    public void DrawEverything() {
        Raylib.BeginDrawing();
    
        Raylib.ClearBackground(Color.BLACK);
        
        Raylib.DrawTextEx(Raylib.GetFontDefault(), GameManager.CurrentLine.CurrentText, new Vector2(Settings.LineMargin, Settings.LineMargin), Settings.FontSize, Settings.Spacing, Color.WHITE);
        
        float textHeight = Raylib.MeasureTextEx(Raylib.GetFontDefault(), GameManager.CurrentLine.CurrentText, Settings.FontSize, Settings.Spacing).Y + Settings.LineSpacing;

        if (GameManager.CurrentLine.IsDone) {
            float optionSpacing = 0;
            foreach (Option o in GameManager.CurrentOptions) {
                string text = o.IsSelected ? "< " + o.Description + " >" : o.Description;
                Raylib.DrawTextEx(Raylib.GetFontDefault(), text, new Vector2(Settings.LineMargin + optionSpacing, textHeight + Settings.LineSpacing), Settings.FontSize, Settings.Spacing, Color.WHITE);
                optionSpacing += Raylib.MeasureTextEx(Raylib.GetFontDefault(), text, Settings.FontSize, Settings.Spacing).X + Settings.OptionMargin;
            }
        }

        Raylib.EndDrawing();
    }

}