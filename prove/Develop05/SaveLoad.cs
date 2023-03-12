using System;
using static System.Console;

public class SaveLoad
{
    private List<Goal> _goals = new List<Goal>();
    private int _points = 0;

    public SaveLoad()
    {
    
    }

    public void SaveGoal(List<Goal> goals, int points)
    {
        Write("What is the name of the file to save to? ");
        string fileSave = ReadLine();
        using (StreamWriter sw = new StreamWriter(fileSave, true))
        {
            sw.WriteLine(points);                    
            foreach (Goal save in goals)
            {
                sw.WriteLine($"{save.SaveGoal()}");
            } 
        }
    }

    public void LoadGoal()
    {
        Write($"What is the name of the file to load from? ");
        string fileLoad = ReadLine();
        string line;

        using (StreamReader sr = new StreamReader(fileLoad))
        {
            line = sr.ReadLine();
            _points = int.Parse(line);

            while ((line = sr.ReadLine()) != null)
            {
                string[] goalParts = line.Split(",");
                string typeGoal = goalParts[0];

                if (typeGoal == "Simple Goal:")
                {
                    var goal = new SimpleGoal(goalParts[1], goalParts[2]);
                    _goals.Add(goal);
                }

                else if (typeGoal == "Eternal Goal:")
                {
                    var goal = new EternalGoal(goalParts[1], goalParts[2]);
                    _goals.Add(goal);
                }

                else if (typeGoal == "Checklist Goal:")
                {
                    var goal = new ChecklistGoal(goalParts[1], goalParts[2], int.Parse(goalParts[3]), int.Parse(goalParts[4]));
                    _goals.Add(goal);
                }
                line = sr.ReadLine();
            }
        }
    }

    public List<Goal> GetGoal()
    {
        return _goals;
    }

    public int GetPoints()
    {
        return _points;
    }
}