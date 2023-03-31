using System.Text;

public class Gathering : Events
{
    private string _temp = "";
    private string _condition = "";
    private string _humidity = "";
    private string _windSpeed = "";
    private string _rainChance = "";

    public Gathering(string eventTitle, string speaker, string eventType, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address)
    : base(eventTitle, speaker, eventType, description, dateOnly, startTime, endTime, address)
    {
        
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

    public string GetWeather()
    {
        return ($"Condition: {this.GetCondition()}\nTemperature: {this.GetTemperature()}\nHumidity: {this._humidity}\nChances of Rain: {this._rainChance}\nWind Speed: {this._windSpeed}");
    }
}