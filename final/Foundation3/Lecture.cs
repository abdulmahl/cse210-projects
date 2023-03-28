

public class Lecture : Event
{
    private string _speakerName = "";
    private int _capacity = 0;
    
    public Lecture(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    : base(eventTitle, eventType, description, dateOnly, timeOnly, address)
    {

    }
}