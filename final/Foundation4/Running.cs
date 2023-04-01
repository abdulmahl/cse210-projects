using static System.Console;


public class Running : Activity
{
    private double _distance;
    public Running(string date, int lengthMinutes, double distance)
    : base(date, lengthMinutes)
    {
        this._distance = distance;
    }

    public override double GetDistance()
    {
        return this._distance;
    }

    public override double GetSpeed()
    {
        double speed = (60 / GetPace());
        return Math.Round(speed, 2);
    }

    public override double GetPace()
    {
        double pace = base.GetLength() / this._distance;
        return Math.Round(pace, 2);
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        int lengthMinutes = base.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();
        return $"{date}, Running: ({lengthMinutes} Minutes) - Distance: {distance} km, Speed: {speed} km/h, Pace: {pace} min per km";
    }
}