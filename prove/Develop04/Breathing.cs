using System;
using static System.Console;

public class Breathing : Activity
{
    // private Spinner _spinner;

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
        base.SetMessage1("\nWell done!!");
    }

    public string GetBreathIn()
    {
        return this._breathIn;
    }

    public string GetBreathOut()
    {
        return $"{this._breathOut}";
    } 

    public void ShowBreathingActivity()
    {
        string actName = base.GetName();
        string description = base.GetDescription();
        string duration = base.GetDuration();
        string msg1 = base.GetMessage1();
        string breathIn = this.GetBreathIn();
        string breathOut = this.GetBreathOut();

        Clear();
        WriteLine($"Welcome to the {actName}\n");
        WriteLine($"{description}\n");
        Write(duration);
        int seconds = int.Parse(ReadLine());
        Clear();
        WriteLine("Get ready...");

        var _spinner = new Spinner();
        _spinner.GetSpin();

        Write(" ");
        WriteLine("");

        Write($"{breathIn}");
        var countIn = new CountDown(4);
        countIn.GetCounter();
        WriteLine("");

        Write(breathOut);
        var countOut = new CountDown(6);
        countOut.GetCounter();
        WriteLine("");

WriteLine("");
        Write($"{breathIn}");
        var countIn1 = new CountDown(4);
        countIn1.GetCounter();
        WriteLine("");

        Write(breathOut);
        var countOut1 = new CountDown(6);
        countOut1.GetCounter();
        WriteLine("");

WriteLine("");
        Write($"{breathIn}");
        var countIn2 = new CountDown(4);
        countIn2.GetCounter();
        WriteLine("");

        Write(breathOut);
        var countOut2 = new CountDown(6);
        countOut2.GetCounter();
        WriteLine("");

WriteLine("");
        Write($"{breathIn}");
        var countIn3 = new CountDown(4);
        countIn3.GetCounter();
        WriteLine("");

        Write(breathOut);
        var countOut3 = new CountDown(6);
        countOut3.GetCounter();

        WriteLine($"\n{msg1}");

        _spinner.GetSpin();

        Write(" ");
        
        base.SetMessage2($"\nYou have completed another {seconds} seconds of the {base.GetName()}");
        string msg2 = base.GetMessage2();
        WriteLine($"{msg2}");

        _spinner.GetSpin();
        Clear();
    }
}