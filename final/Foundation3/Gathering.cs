using System.Text;

public class Gathering : Events
{
    private string _temp = "";
    private string _condition = "";
    private string _humidity = "";
    private string _windSpeed = "";
    private string _rainChance = "";

    public Gathering(string eventTitle, string eventType, string description, DateOnly dateOnly, TimeOnly timeOnly, Address address)
    : base(eventTitle, eventType, description, dateOnly, timeOnly, address)
    {
        
    }

    public string GetWeather()
    {
        var weatherReport = new StringBuilder();
        weatherReport.AppendLine($"Condition: {this._condition}\nTemperature: {this._temp}\nHumidity: {this._humidity}\nChances of Rain: {this._rainChance}");
        return weatherReport.ToString();
    }
}