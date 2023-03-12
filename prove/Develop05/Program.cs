using System;
using static System.Console;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        int points = 0;

        WriteLine($"You have 0 points\n");
        string choice = "";
        while (choice != "6")
        {
            WriteLine("Menu Options:");
            WriteLine("  1. Create New Goal");
            WriteLine("  2. List Goals");
            WriteLine("  3. Save Goals");
            WriteLine("  4. Load Goals");
            WriteLine("  5. Record Event");
            WriteLine("  6. Return");
            Write("Select a choice from the menu: ");
            choice = ReadLine();

            switch (choice)
            {
                case "1": // Choice + Sub-Menu.
                    string type1 = "";
                    WriteLine("The types of Goals are:");
                    WriteLine("  1. Simple Goal");   
                    WriteLine("  2. Eternal Goal");   
                    WriteLine("  3. Checklist Goal");
                    Write("Which type of goal would you like to create ");
                    type1 = ReadLine();

                    switch (type1)
                    {
                        case "1": // Simple goal option.
                            var sGoal = new SimpleGoal();
                            goals.Add(sGoal);
                            WriteLine($"\nYou have {0} points.\n");
                        break;

                        case "2": // Eternal goal option.
                            var eGoal = new EternalGoal();
                            goals.Add(eGoal);
                            WriteLine($"\nYou have {0} points.\n");
                        break;

                        case "3": // Checklist goal option.
                            var cGoal = new ChecklistGoal();
                            goals.Add(cGoal);
                            WriteLine($"\nYou have {0} points.\n");
                        break;
                        
                        default:
                        break;
                    }

                break;

                case "2": // List
                    int i = 0;
                    WriteLine("\nThe Goals are:");
                    foreach (Goal goal in goals)
                    {
                        i++;
                        goal.GetGoalList1(i);
                    }
                    WriteLine($"\nYou have {points} points\n");
                break;

                case "3": // Save to text file.
                    var saveGoal = new SaveLoad();
                    saveGoal.SaveGoal(goals, points);
                    WriteLine($"\nYou have {points} points\n");
                break;

                case "4": // Load from a text file.
                    var loadGoal = new SaveLoad();
                    loadGoal.LoadGoal();
                    goals = loadGoal.GetGoal();
                    points = loadGoal.GetPoints();
                    WriteLine($"\nYou have {points} points\n");
                break;

                case "5": // Record Event.
                    int j = 1;
                    WriteLine("\nThe Goals are:");
                    foreach (Goal goal in goals)
                    {
                        j++;
                        goal.GetGoalList2(j);   
                    }
                    Write($"Which goal did you accomplish? ");
                    int type2 = int.Parse(ReadLine());

                    Goal typeGoal = goals[type2 - 1];
                    typeGoal.RecordEvent();

                    points = points + typeGoal.GetPoints();
                    WriteLine($"Congratulations you have earned {typeGoal.GetPoints()} points.");
                    WriteLine($"\nYou have {points} points");
                    WriteLine();
                break;  

                default: // Quit program.
                    Clear();
                break;
            }
        }
    }
}
