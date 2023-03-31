

public class Lecture : Events
{
    private string _speaker = "";
    private int _capacity = 0;
    private string _eventType = "";

    public Lecture(string eventTitle, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address, string speaker, int capacity, string eventType)
    : base(eventTitle, description, dateOnly, startTime, endTime, address)
    {
        this._speaker = speaker;
        this._capacity = capacity;
        this._eventType = eventType;
    }

    public string GetStdDetailsLecture()
    {
        return $"Title: {base._eventTitle}\n\nDescription: {base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}";
    }

    public string GetFullDetailsLecture()
    {
        return $"Title: {base._eventTitle}\n\nDescription: {base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}\n\nSpeaker: {this._speaker}\nLimited Capacity: {this._capacity} Seated";

    }

    public string GetShortDescriptionLecture()
    {
        return $"Event Type: {this._eventType}\nEvent Title: {base._eventTitle}\nEvent Date: {base._dateOnly}";
    }
}