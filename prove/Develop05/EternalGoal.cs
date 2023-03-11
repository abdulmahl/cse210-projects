using static System.Console;
using System.IO;

public class EternalGoal : Goal
{
    public EternalGoal() 
    : base()
    {
        base._completed = false;
    }
    
    public EternalGoal(string goalName, string description, int points, bool completed)
    : base(goalName, description, points)
    {
    }
    public override void RecordEvent()
    {
    }

    public override string SaveGoal() // Writes Goals to a text file.
    {
        return $"Eternal Goal:{base._goalName},{base._description},{base._points}";
    }
}