using System;

public class Reflecting : Activity
{
    private string _prompt;
    private string _question;
    public Reflecting(string actName, string description, string duration, string endMsg, string prompt, string question) 
    : base(actName, description, duration, endMsg)
    {
        _prompt = prompt;
        _question = question;
    }

}