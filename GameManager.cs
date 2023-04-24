public static class GameManager {
    public static Text CurrentLine = new("");

    static Text[] lines = new Text[] {
        new("As children, curiosity was our primary learning tool. It made us wiggle."),
        new("In a series of four experiments, behavioral scientists.")
    };
    
    public static async void ExcecuteActions() {
        foreach (Text t in lines) {
            CurrentLine = t;
            await t.Write();
        }
    }
}