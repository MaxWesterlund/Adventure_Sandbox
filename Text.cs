using Raylib_cs;

// Beskrivning: Håller information om ett textstycke.
public class Text {
    public bool IsDone;
    public bool HasSelected;

    public string CurrentText = "";
    public Option[] Options;

    string finalText;

    public Text(string text, Option[] options) {
        finalText = text;
        Options = options;
    }

    // Beskrivning: Skriver ut given string med lite delay mellan varje char. Specifika tecken har även mer/mindre delay.
    // Argument 1: String som används för att veta vad som står på den nuvarande raden. Den är frivillig och bör inte tillges ett värde då funktionen körs.
    // Argument 2: Boolean som är true om texten ska skippas för att nå alternativen direkt. Den är frivillig och bör inte tillges ett värde då funktionen körs.
    // Return: Funktionen returner typen Task. Inget return statement behövs för att returnera Task. Det säger till funktionen som kör den här funktionen hur långt den kommit.
    // Exempel: På grund av Task typens sätt att returnera går det inte att göra exempel.
    public async Task Write(string currentLine = "", bool skipped = false) {
        foreach (char c in finalText) {
            if (Raylib.MeasureTextEx(Raylib.GetFontDefault(), currentLine, Settings.FontSize, Settings.Spacing).X + Settings.LineMargin >= Raylib.GetScreenWidth() - Settings.LineMargin * 2) {
                CurrentText += "\n";
                currentLine = "";
            }
            currentLine += c;
            CurrentText += c;
            int delay = 0;
            if (!skipped) {
                delay = 50;
                switch (c) {
                    case (' '):
                        delay = 25;
                        break;
                    case (','):
                        delay = 75;
                        break;
                    case ('.'):
                        delay = 100;
                        break;
                }
            }
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE)) {
                skipped = true;
            }
            if (CurrentText == finalText) {
                delay = 500;
            }
            await Task.Delay(delay);
        }
    }
}