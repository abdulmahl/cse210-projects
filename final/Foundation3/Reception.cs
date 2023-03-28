

public class Reception : Event
{
    private string _Email = "";
    
    public Reception(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    : base(eventTitle, eventType, description, dateOnly, timeOnly, address)
    {
        
    }
}