using static System.Console;


public class Swimming : Activity
{
    private double _laps;
    public Swimming(string date, int lengthMinutes, double laps)
    : base(date, lengthMinutes)
    {
        this._laps = laps;
    }

    public override double GetDistance()
    {
        double laps = (_laps * 50) / 1000;
        return Math.Round(laps, 2);
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return Math.Round(pace, 2);
    }
    public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return Math.Round(speed, 2);
    }


    public override string GetSummary()
    {
        string date = base.GetDate();
        int lengthMinutes = base.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();
        return $"{date}, Swimming: ({lengthMinutes} Minutes) - Distance: {distance} km, Speed: {speed} km/h, Pace: {pace} min per km ";
    }
}