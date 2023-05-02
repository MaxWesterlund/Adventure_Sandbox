using Raylib_cs;

public static class GameManager {
    public static Text CurrentLine = new("", new Option[0]);
    public static List<Option> CurrentOptions = new();

    public static Option SelectedOption = new("", global::Events.Empty);

    static Text nextText = new Text(
        "Du är en arbetare på fabriken där Carls nötterTM tillverkas. Du jobbar långa timmar för en liten lön eftersom Carl är en girig kapitalist som bara bryr sig om att tjäna mer pengar. Medan du och dina kollegor jobbar hårt går han alltid runt i fabriken och beklagar sig på er ineffektivitet. Men idag har du fått nog, det har blivit dags för dig att mörda Carl och ta över hans fabrik. \nDitt äventyr börjar vid din maskin i fabriken (Den som sätter på skalen på nötterna). Den ligger vid entren till fabriken vilket irriterande nog ligger längst bort från Carls kontor där han sitter och röker en asbestoscigarr. Hur vill du börja ta dig mot kontoret?",
        new Option[] {
            new("Åk på rullbandet", global::Events.RideRollband),
            new("Gå upp för trappan", global::Events.GoUpStairs),
            new("Använd din Carls nötter nöt-jetpack", global::Events.RideJetpack)
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
                }
            }
        }
    }
}