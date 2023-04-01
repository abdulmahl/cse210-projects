using System.Text;

public class Gathering : Events
{
    private string _tempMax = "";
    private string _tempMin = "";
    private string _condition = "";
    private string _humidity = "";
    private string _windSpeed = "";
    private string _rainChance = "";
    private string _eventType = "";


    public Gathering(string eventTitle, string description, string dateOnly, TimeOnly startTime, TimeOnly endTime, Address address, string eventType, string tempMax, string tempMin, string condition, string humidity, string windSpeed, string rainChance)
    : base(eventTitle, description, dateOnly, startTime, endTime, address)
    {
        this._tempMax = tempMax;
        this._tempMin = tempMin;
        this._condition = condition;
        this._humidity = humidity;
        this._windSpeed = windSpeed;
        this._rainChance = rainChance;
        this._eventType = eventType;
    }


    public string GetTemperatureMax()
    {
        return this._tempMax;
    }

    public string GetTemperatureMin()
    {
        return this._tempMin;
    }

    public string GetCondition()
    {
        return this._condition;
    }

    public string GetHumidity()
    {
        return this._humidity;
    }

    public string GetWindSpeed()
    {
        return this._windSpeed;
    }

    public string GetRainChance()
    {
        return this._rainChance;
    }

    public string GetStdDetailsGathering()
    {
        return $"Title: {base._eventTitle}\n\nDescription:\n{base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}";
    }

    public string GetFullDetailsGathering()
    {
        return $"Title: {base._eventTitle}\n\nDescription:\n{base._description}\n\nDate: {base._dateOnly}\nTime: {base._startTime} - {base._endTime}\nLocation: {base._address.GetFullAddress()}\n\nTemp Max: {this.GetTemperatureMax()}\nTemp Min: {this.GetTemperatureMin()}\nCondition: {this.GetCondition()}\nHumidity: {this.GetHumidity()}\nWind Speed: {this.GetWindSpeed()}\nChances of Rain: {this.GetRainChance()}";
    }

  
    public string GetShortDescriptionGathering()
    {
        return $"Event Type: {this._eventType}\nEvent Title: {base._eventTitle}\nEvent Date: {base._dateOnly}";
    }
}