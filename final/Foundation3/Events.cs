using static System.Console;
public class Events
{
    private string _eventTitle = "";
    private string _eventType = "";
    private string _description = "";
    private DateTime _dateOnly = DateTime.Now.Date;
    private TimeOnly _timeOnly;
    private Address _address;

    public Events(string eventTitle, string eventType, string description, DateTime dateOnly, TimeOnly timeOnly, Address address)
    {
       this._eventTitle = eventTitle;
       this._eventType = eventType;
       this._description = description;
       this._dateOnly = dateOnly;
       this._timeOnly = timeOnly;
       this._address = address;
    }

    public string GetEventTitle()
    {
        return this._eventTitle;
    }

    public void SetEventTitle(string eventTitle)
    {
        this._eventTitle = eventTitle;
    }  

    public string GetEventType()
    {
        return this._eventType;
    }

    public void SetEventType(string eventType)
    {
        this._eventType = eventType;
    }

    public string GetEventDescription()
    {
        return this._description;
    }

    public void SetEventDescription(string description)
    {
        this._description = description;
    }

    public DateTime GetDateOnly()
    {
        return _dateOnly;
    }

    public void SetDateOnly(DateTime dateOnly)
    {
        this._dateOnly = dateOnly;
    }

    public TimeOnly GetTimeOnly()
    {
        return _timeOnly;
    }

    public void SetTimeOnly(TimeOnly timeOnly)
    {
        this._timeOnly = timeOnly;
    }

    public Address GetAddress()
    {
        return this._address;
    }
    
    public string GetStdDetails()
    {
        return $"Title: {this._eventTitle}\nDescription: {this._description}\nDate: {this.GetDateOnly()}\nTime: {this.GetTimeOnly()}\nAddress: {this.GetAddress().GetFullAddress()}";
    }

    public string GetFullDetails()
    {
        return "";
    }

    public string GetShortDescription()
    {
        return this._eventType + ", " + this._eventTitle + ", " + this._dateOnly;
    }
}