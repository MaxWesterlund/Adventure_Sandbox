using Raylib_cs;

public class Text {
    public bool IsDone;
    public bool HasSelected;

    public string CurrentText = "";
    public Option[] Options;

    string finalText;

    int index = 0;

    public Text(string text, Option[] options) {
        finalText = text;
        Options = options;
    }

    public async Task Write(string currentLine = "") {
        foreach (char c in finalText) {
            if (Raylib.MeasureTextEx(Raylib.GetFontDefault(), currentLine, Settings.FontSize, Settings.Spacing).X >= Raylib.GetScreenWidth() - Settings.LineMargin * 2) {
                CurrentText += "\n";
                currentLine = "";
            }
            currentLine += c;
            CurrentText += c;
            int delay = 50;
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
            if (CurrentText == finalText) {
                delay = 500;
            }
            await Task.Delay(delay);
        }
    }
}