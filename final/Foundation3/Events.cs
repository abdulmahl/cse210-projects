public class Events
{
    private string _eventTitle = "";
    private string _eventType = "";
    private string _description = "";
    private DateOnly _dateOnly;
    private TimeOnly _timeOnly;
    private Address _address;

    public Events(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    {
       this._eventTitle = eventTitle;
       this._eventType = eventType;
       this._description = description;
       this._dateOnly = dateOnly;
       this._timeOnly = timeOnly;
       this._address = address;
    }

    public DateOnly GetDateOnly()
    {
        DateOnly dateOnly = DateOnly.MaxValue.AddYears(-7976).AddDays(-19).AddMonths(-8);
        return dateOnly;
    }

    public TimeOnly GetTimeOnly()
    {
        TimeOnly timeOnly = TimeOnly.MaxValue.AddHours(-8).AddMinutes(1);
        return timeOnly;
    }
    
    public string GetStdDetails()
    {
        return $"Title: {this._eventTitle}\nDescription: {this._description}\nDate: {this.GetDateOnly()}\nTime: {this.GetTimeOnly()}\nAddress: {this._address.GetFullAddress()}";
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