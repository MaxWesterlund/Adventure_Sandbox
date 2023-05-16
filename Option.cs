// Beskrivning: Håller information om vad ett alternativs egenskaper.
public class Option {
    public string Description;
    public Event Event;
    public bool IsSelected = false;
    
    public Option(string description, Event Ev) {
        Description = description;
        Event = Ev;
    }
}