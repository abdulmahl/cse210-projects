using System;
using static System.Console;

public class Listing : Activity
{
    private Spinner _spinner = new Spinner();
    private string [] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing() 
    : base()
    {
        base.SetName("Listing Activity");
        base.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        base.SetDuration("How long, in sceonds, would you like for your session? ");
        base.SetMessage1("\nWell done!!");
    }

    public void GetListingPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        string randPrompt = _prompts[index];

        WriteLine($"  ---{randPrompt}---");
        Write($"You may begin in: ");
        var _counter = new CountDown(5);
        _counter.GetCounter();
        WriteLine("");
    }

    public void ShowListingActivity()
    {

        string actName = base.GetName();
        string description = base.GetDescription();
        string duration = base.GetDuration();
        string msg1 = base.GetMessage1();

        Clear();
        WriteLine($"Welcome to the {actName}\n");
        WriteLine($"{description}\n");
        Write($"{duration}");
        int seconds = int.Parse(ReadLine());
        // Read();
        Clear();
        WriteLine("Get ready...");

        this._spinner.GetSpinner();
        Write(" ");

        WriteLine("\nList as many responses as you can to the following prompt:");
        this.GetListingPrompt();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);

        var countInput = 0;
        while (DateTime.Now < endTime)
        {
            Write("> ");
            ReadLine();
            countInput += 1;
        }
        WriteLine($"\nYou have listed {countInput} items.");

        WriteLine($"{msg1}");
        this._spinner.GetSpinner();

        base.SetMessage2($"\nYou have completed another {seconds} seconds of the {base.GetName()}");
        string msg2 = base.GetMessage2();
        WriteLine($"{msg2}");
        this._spinner.GetSpinner();
        Clear();
    }
}