using System;
using static System.Console;

public class Listing : Activity
{
    // CountDown countSeconds = new CountDown();
    private static System.Timers.Timer aTimer;

    // private string _prompt;
    private string [] _prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public Listing(string actName, string description, string duration, string endMsg) 
    : base(actName, description, duration, endMsg)
    {
        // _prompt = prompt;
    }

    public void GetPrompt()
    {
        // var countInput = 0;
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        string randPrompt = _prompts[index];

        WriteLine($"\n---{randPrompt}---");
        WriteLine($"You may begin in: ");
        string input = ReadLine();

        aTimer = new System.Timers.Timer(30000);
        while (true)
        {
            Write("> ");
            ReadLine();
        }
    }
}