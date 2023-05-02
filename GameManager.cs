using Raylib_cs;

public static class GameManager {
    public static Text CurrentLine = new("", new Option[0]);
    public static List<Option> CurrentOptions = new();

    public static Option SelectedOption = new("", global::Events.Empty);

    static Text nextText = new Text(
        "Du arbetar i fabriken \"Carls Nötter\". Du jobbar långa timmar under den onda kapitalisten Carls styre. Nu har du bestämt dig för att trotsa Carl och slå dig fri.",
        new Option[] {
            new("Slå dig fri", global::Events.BreakFree),
            new("Nöj dig med ditt jobb", global::Events.Stay)
        }
    );
    
    public static async void ExcecuteActions(bool isDone = false) {
        while (!isDone) {
            CurrentOptions.Clear();
            CurrentLine = nextText;
            await nextText.Write();
            nextText.IsDone = true;

            foreach (Option o in CurrentLine.Options) {
                await Task.Delay(200);
                CurrentOptions.Add(o);
            }

            int index = 0;
            bool hasSelected = false;
            while (!hasSelected) {
                if (CurrentOptions.Count <= 0) {
                    nextText.HasSelected = true;
                    break;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) {
                    index += 1;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) {
                    index -= 1;
                }
                if (index < 0) {
                    index = CurrentOptions.Count - 1;
                }
                else if (index >= CurrentOptions.Count) {
                    index = 0;
                }
                for (int i = 0; i < CurrentOptions.Count; i++) {
                    if (i == index) {
                        SelectedOption = CurrentOptions[i];
                        CurrentOptions[i].IsSelected = true;
                    }
                    else {
                        CurrentOptions[i].IsSelected = false;
                    }
                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_ENTER)) {
                    hasSelected = true;
                    nextText = GetTextFromEvent(SelectedOption.Event);
                }
            }
        }
    }
    
    static Text GetTextFromEvent(Events events) {
        Text text = new Text("", new Option[0]);
        switch (events) {
            case (Events.BreakFree):
                text = new Text("Du slog dig fri!", new Option[] {
                    new("Jag stannar nog förresten", Events.Stay)
                });
                break;
            case (Events.Stay):
                text = new Text("Du nöjde dig.", new Option[] {
                    new("Jag ångrade mig", Events.BreakFree)
                });
                break;
        }
        
        return text;
    }  
}