

public class Reception : Events
{
    private string _Email = "";

    public Reception(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    : base(eventTitle, eventType, description, dateOnly, timeOnly, address)
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