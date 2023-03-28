

public class Lecture : Events
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    : base(eventTitle, eventType, description, dateOnly, timeOnly, address)
    {

    }

    public string GetSpeaker()
    {
        return this._speaker;
    }

    public int GetCapacity()
    {
        return this._capacity;
    }

    public void SetSpeaker(string speaker)
    {
        this._speaker = speaker;
    }

    public void SetCapacity(int capacity)
    {
        this._capacity = capacity;
    }
}