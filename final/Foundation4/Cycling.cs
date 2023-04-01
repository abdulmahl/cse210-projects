using static System.Console;


public class Cycling : Activity
{
    private double _speed;
    public Cycling(string date, int lengthMinutes, double distance, double speed)
    : base(date, lengthMinutes)
    {
        this._speed = speed;
    }

    public override double GetSpeed()
    {
        double speed = (60 / GetPace());
        return Math.Round(speed, 2);
    }

    public override double GetDistance()
    {
        double distance = base.GetLength() / this._speed;
        return Math.Round(distance, 2);
    }

    public override double GetPace()
    {
        double pace = GetLength() / GetDistance();
        return Math.Round(pace, 2);
    }

    public override string GetSummary()
    {
        string date = base.GetDate();
        int lengthMinutes = base.GetLength();
        double distance = this.GetDistance();
        double speed = this.GetSpeed();
        double pace = this.GetPace();
        return $"{date}, Cycling: ({lengthMinutes} Minutes) - Distance: {distance} km, Speed: {speed} km/h, Pace: {pace} min per km";
    }
}