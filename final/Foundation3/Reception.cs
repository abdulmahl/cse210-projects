

public class Reception : Events
{
    private string _Email = "";

    public Reception(string eventTitle, string speaker, string eventType, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address)
    : base(eventTitle, speaker, eventType, description, dateOnly, startTime, endTime, address)
    {
        
    }

    public string GetEmail()
    {
        return this._Email;
    }

    public void SetEmail(string Email)
    {
        this._Email = Email;
    }
}