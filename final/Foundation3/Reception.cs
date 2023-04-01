

public class Reception : Events
{
    private string _Email = "";
    private string _phoneNumber = "";
    private string _eventType = "";

    public Reception(string eventTitle, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address, string eventType, string Email, string phoneNumber)
    : base(eventTitle, description, dateOnly, startTime, endTime, address)
    {
        this._Email = Email;
        this._phoneNumber = phoneNumber;
        this._eventType = eventType;
    }

    public string GetStdDetailsReception()
    {
        return $"Title: {base._eventTitle}\n\nDescription:\n{base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}";
    }

    public string GetFullDetailsReception()
    {
        return $"Title: {base._eventTitle}\n\nDescription:\n{base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}\n\nRSVP: {this._Email}\nContact: {this._phoneNumber} For more information";
    }

    public string GetShortDescriptionReception()
    {
        return $"Event Type: {this._eventType}\nEvent Title: {base._eventTitle}\nEvent Date: {base._dateOnly}";
    }
}