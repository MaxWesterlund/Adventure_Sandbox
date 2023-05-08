using Raylib_cs;

public static class GameManager {
    public static Text CurrentLine = new("", new Option[0]);
    public static List<Option> CurrentOptions = new();

    public static Option SelectedOption = new("", global::Events.Empty);
    
    public static async void ExcecuteActions(bool isDone = false) {
        Text nextText = Texts.GetTextFromEvent(Saving.LoadData());
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
                    await Task.Delay(50);
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) {
                    index -= 1;
                    await Task.Delay(50);
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
                    nextText = Texts.GetTextFromEvent(SelectedOption.Event);
                    Saving.SaveData((int)SelectedOption.Event);
                }
            }
        }
    }
}