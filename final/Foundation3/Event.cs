using System.Text;

public class Event
{
    private string _eventTitle = "";
    private string _eventType = "";
    private string _description = "";
    private DateOnly _dateOnly;
    private TimeOnly _timeOnly;
    private Address _address;

    public Event(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    {
       this._eventTitle = eventTitle;
       this._eventType = eventType;
       this._description = description;
       this._dateOnly = dateOnly;
       this._timeOnly = timeOnly;
       this._address = address;
    }

    public string GetStdDetails()
    {
        var stdDetails = new StringBuilder();
        stdDetails.AppendLine($"Title: {this._eventTitle}\nDescription: {this._description}\nDate: {this._dateOnly}\nTime: {this._timeOnly}\nAddress: {this._address}");
        return stdDetails.ToString();
    }

    public string GetFullDetails()
    {
        return "";
    }

    public string GetShortDescription()
    {
        return this._eventType + " " + this._eventTitle + " " + this._dateOnly;
    }
}