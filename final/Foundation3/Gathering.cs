using System.Text;

public class Gathering : Events
{
    private string _temp = "";
    private string _condition = "";
    private string _humidity = "";
    private string _windSpeed = "";
    private string _rainChance = "";
    private string _eventType = "";


    public Gathering(string eventTitle, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address, string eventType)
    : base(eventTitle, description, dateOnly, startTime, endTime, address)
    {
        this._eventType = eventType;
    }

    public string GetTemperature()
    {
        return this._temp;
    }

    public void SetTemperature(string temp)
    {
        this._temp = temp;
    }

    public string GetCondition()
    {
        return this._condition;
    }

    public void SetCondition(string condition)
    {
        this._condition = condition;
    }

    public string GetHumidity()
    {
        return this._humidity;
    }

    public void SetHumidity(string humidity)
    {
        this._humidity = humidity;
    }

    public string GetWindSpeed()
    {
        return this._windSpeed;
    }

    public void SetWindSpeed(string windSpeed)
    {
        this._windSpeed = windSpeed;
    }

    public string GetRainChance()
    {
        return this._rainChance;
    }

    public void SetRainChange(string rainChance)
    {
        this._rainChance = rainChance;
    }

    public string GetStdDetailsGathering()
    {
        return $"Title: {base._eventTitle}\nDescription: {base._description}\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address}\n";
    }

    public string GetFullDetailsGathering()
    {
        return "";
    }

  
    public string GetShortDescriptionGathering()
    {
        return $"Event Type: {this._eventType}\nEvent Title: {base._eventTitle}\nEvent Date: {base._dateOnly}";
    }
}