using static System.Console;
using System.IO;

public class SimpleGoal : Goal
{
    public SimpleGoal() 
    : base()
    {
    }

    public SimpleGoal(string goalName, string description)
    : base(goalName, description)
    {

    }

    public override void RecordEvent()
    {
        base._completed = true;
    }

    public override void GetGoalList1(int number)
    {
        string mark_X = "";
        if (base._completed)
        mark_X = "X";
        WriteLine($"{number}. [{mark_X}] {base._goalName} ({base._description})");
    }

    public override string SaveGoal() // Writes Goals to a text file.
    {
        return $"Simple Goal:{base._goalName},{base._description},{base._points},{base.IsComplete()}";
    }
}