using Raylib_cs;

public static class GameManager {
    public static Text CurrentLine = new("", new Option[0]);
    public static List<Option> CurrentOptions = new();

    public static Option SelectedOption = new("");

    static Text[] lines = new Text[] {
        new("As children, curiosity was our primary learning tool. It made us wiggle.", new Option[0]),
        new("In a series of four experiments, behavioral scientists.", new Option[] {
            new("Option 1"),
            new("Option 2")
        })
    };
    
    public static async void ExcecuteActions() {
        foreach (Text t in lines) {
            CurrentLine = t;
            await t.Write();
            t.IsDone = true;
            foreach (Option o in CurrentLine.Options) {
                await Task.Delay(200);
                CurrentOptions.Add(o);
            }
            int index = 0;
            while (!t.HasSelected) {
                if (CurrentOptions.Count <= 0) {
                    t.HasSelected = true;
                    break;
                }
                if (Raylib.IsKeyPressed(KeyboardKey.KEY_RIGHT)) {
                    Console.WriteLine("Right");
                    index += 1;
                }
                else if (Raylib.IsKeyPressed(KeyboardKey.KEY_LEFT)) {
                    Console.WriteLine("Left");
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
                        CurrentOptions[i].IsSelected = true;
                    }
                    else {
                        CurrentOptions[i].IsSelected = false;
                    }
                }
            }
        }
    }
}