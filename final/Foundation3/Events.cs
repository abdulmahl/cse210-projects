using static System.Console;
public class Events
{
    protected string _eventTitle = "";
    protected string _description = "";
    protected string _dateOnly;
    protected TimeOnly _startTime;
    protected TimeOnly _endTime;
    protected Address _address;

    public Events(string eventTitle, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address)
    {
       this._eventTitle = eventTitle;
       this._description = description;
       this._dateOnly = dateOnly;
       this._startTime = startTime;
       this._endTime = endTime;
       this._address = address;
    }
}