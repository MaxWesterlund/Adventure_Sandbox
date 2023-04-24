using Raylib_cs;

public class Text {
    public bool IsDone = false;
    public string CurrentText = "";

    string finalText;

    int index = 0;

    public Text(string text) {
        finalText = text;
    }

    public async Task Write() {
        foreach (char c in finalText) {
            CurrentText += c;
            int delay = 100;
            switch (c) {
                case(' '):
                    delay = 50;
                    break;
                case('.'):
                    delay = 200;
                    break;
                case(','):
                    delay = 150;
                    break;
            }
            await Task.Delay(delay);
        }
    }
}