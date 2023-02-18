using System;
using static System.Console;

public class Breathing : Activity
{
    private string _breathIn = "";
    private string _breathOut = "";

    

    public Breathing(string actName, string description, string duration, string endMsg) 
    : base(actName, description, duration, endMsg)
    {
        _breathIn = "";
        _breathOut = "";
    }

    public string GetBreathIn()
    {
        return _breathIn;
    }

    public string GetBreathOut()
    {
        return _breathOut;
    } 
}