using System;
using static System.Console;

public class Breathing : Activity
{
    private string _breathIn;
    private string _breathOut;

    public Breathing() 
    : base()
    {
        _breathIn = $"Breath in...";
        _breathOut = "Now breath out...";

        base.SetName("Breathing Activity");
        base.SetDescription("This activity will help you ralax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
        base.SetDuration("How long, in sceonds, would you like for your session? ");
        base.SetMessage1("Well done!!");
    }

    public void GetBreathIn()
    {
        Write(_breathIn);
        var countIn = new CountDown(4);
        countIn.GetCounter();
        WriteLine("");
    }

    public void GetBreathOut()
    {
        Write(_breathOut);
        var countOut = new CountDown(6);
        countOut.GetCounter();
        WriteLine("");
    } 

    public void ShowBreathingActivity()
    {
        string actName = base.GetName();
        string description = base.GetDescription();
        string duration = base.GetDuration();
        string msg1 = base.GetMessage1();
    
        Clear();
        WriteLine($"Welcome to the {actName}\n");
        WriteLine($"{description}\n");
        Write(duration);
        int seconds = int.Parse(ReadLine());
        Clear();
        WriteLine("Get ready...");

        var _spinner = new Spinner();
        _spinner.GetSpinner();

        Write(" ");
        WriteLine("");

        this.GetBreathIn();
        this.GetBreathOut();
        WriteLine();

        this.GetBreathIn();
        this.GetBreathOut();
        WriteLine();

        this.GetBreathIn();
        this.GetBreathOut();

        WriteLine($"\n{msg1}");

        _spinner.GetSpinner();
        Write(" ");
        
        base.SetMessage2($"\nYou have completed another {seconds} seconds of the {base.GetName()}");
        string msg2 = base.GetMessage2();
        WriteLine($"{msg2}");
        _spinner.GetSpinner();
        Clear();
    }
}