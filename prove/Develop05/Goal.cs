using static System.Console;
using System.IO;

public abstract class Goal
{
    protected string _goalName;
    protected string _description;
    protected int _points = 0;
    protected bool _completed = false;

    public Goal()
    {
        Write("What is the name of your goal? ");
        this._goalName = ReadLine();

        Write("What is a short description of it? ");
        this._description = ReadLine();

        Write("What is the amount of points associated with this goal? ");
        this._points = int.Parse(ReadLine());
    }

    public Goal(string goalName, string description, int points)
    {
    }

    public Goal(string goalName, string description)
    {
    }
    public int GetPoints()
    {
        return this._points;
    }

    public virtual void RecordEvent()
    {
        this._completed = true;
    }

    public virtual bool IsComplete()
    {
        return this._completed = true;
    }

    public virtual void GetGoalList1(int number)
    {
        WriteLine($"{number}. [ ] {this._goalName} ({this._description})"); // Writes to the first list.
    }
    public virtual void GetGoalList2(int number)
    {
        WriteLine($"{number}. {this._goalName}"); // Writes to a small list
    }
    public virtual string SaveGoal() // Writes to a text file.
    {
        return $"{_goalName},{_description},{_points},{_completed}";
    }
}