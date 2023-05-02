public class Option {
    public string Description;
    public Events Event;
    public bool IsSelected = false;

    public Option(string description, Events events) {
        Description = description;
        Event = events;
    }
}