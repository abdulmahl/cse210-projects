using static System.Console;

public abstract class Activity
{
    private DateOnly _dateOnly;
    private int _lengthMinutes = 0;
    public Activity()
    {

    }

    public abstract string GetSummary();
}