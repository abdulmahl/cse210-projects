

public class Lecture : Events
{
    private string _speaker = "";
    private int _capacity = 0;

    public Lecture(string eventTitle, string speaker, string eventType, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address)
    : base(eventTitle, speaker, eventType, description, dateOnly, startTime, endTime, address)
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