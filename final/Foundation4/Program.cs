using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        var running = new Running("12 April 2022", 25, 10);
        var cycling = new Cycling("23 Nov 2022", 45, 15.9, 17.3);
        var swimming = new Swimming("14 Dec 2022", 35, 12.7);

        activities.Add(running);
        activities.Add(cycling);
        activities.Add(swimming);

        Clear();
        foreach (var activity in activities)
        {
            WriteLine(activity.GetSummary());
            WriteLine();
        }
    }
}