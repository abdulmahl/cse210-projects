using static System.Console;

public abstract class Activity
{
    protected string _date;
    protected int _lengthMinutes = 0;

    public Activity(string date, int lengthMinutes)
    {
        this._date = date;
        this._lengthMinutes = lengthMinutes;
    }

    public string GetDate()
    {
        return this._date;
    }

    public int GetLength()
    {
        return this._lengthMinutes;
    }
    
    public abstract double GetSpeed();

    public abstract double GetDistance();

    public abstract double GetPace();

    public abstract string GetSummary();

}