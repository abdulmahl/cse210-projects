using static System.Console;
public class Events
{
    private string _eventTitle = "";
    private string _eventSpeaker = "";
    private string _eventType = "";
    private string _description = "";
    private string _dateOnly;
    private TimeOnly _startTime;
    private TimeOnly _endTime;
    private Address _address;

    public Events(string eventTitle, string speaker, string eventType, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address)
    {
       this._eventTitle = eventTitle;
       this._eventSpeaker = speaker;
       this._eventType = eventType;
       this._description = description;
       this._dateOnly = dateOnly;
       this._startTime = startTime;
       this._endTime = endTime;
       this._address = address;
    }

    public Address GetAddress()
    {
        return this._address;
    }
    
    public string GetStdDetails()
    {
        return $"Title: {this._eventTitle}\nSpeaker: {this._eventSpeaker}\n\nDescription: {this._description}\n\nDate: {this._dateOnly}\nTime: {this._startTime} - {this._endTime}\n\nLocation: {this.GetAddress().GetFullAddress()}";
    }

    public string GetFullDetails()
    {
        return "";
    }

    public string GetShortDescription()
    {
        return $"Event Type: {this._eventType}\nEvent Title: {this._eventTitle}\nEvent Date: {this._dateOnly}";
    }
}