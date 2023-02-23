using System;
using static System.Console;

public class Listing : Activity
{
    private Spinner _spinner = new Spinner();
    private CountDown _counter = new CountDown(5);


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
        // var countInput = 0;
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        string randPrompt = _prompts[index];

        WriteLine($"  ---{randPrompt}---");
        Write($"You may begin in: ");
        _counter.GetCounter();
        WriteLine("");
        string input = ReadLine();

        while (true)
        {
            Write("> ");
            ReadLine();
        }
    }

    public void ShowListingActivity()
    {
        string actName = base.GetName();
        string description = base.GetDescription();
        string duration = base.GetDuration();

        Clear();
        WriteLine($"Welcome to the {actName}\n");
        WriteLine($"{description}\n");
        Write($"{duration}");
        Read();
        Clear();
        WriteLine("Get ready...");

        _spinner.GetSpin();
        Write(" ");

        WriteLine("\nList as many responses as you can to the following prompt:");
        this.GetListingPrompt();
        ReadLine();
    }
}