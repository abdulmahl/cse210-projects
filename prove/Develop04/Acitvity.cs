using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private string _duration;
    private string _message1;
    private string _message2;

    public Activity()
    {
        _activityName = "";
        _description = "";
        _duration = "";
        _message1 = "";
        _message2 = "";
    }

    public string GetName()
    {
        return this._activityName;
    }

    public void SetName(string actName)
    {
        this._activityName = actName;
    }

    public string GetDescription()
    {
        return this._description;
    }

    public void SetDescription(string description)
    {
        this._description = description;
    }
    public string GetDuration()
    {
        return this._duration;
    }

    public void SetDuration(string duration)
    {
        this._duration = duration;
    }

    public string GetMessage1()
    {
        return this._message1;
    }

    public void SetMessage1(string startMsg)
    {
        this._message1 = startMsg;
    }

    public string GetMessage2()
    {
        return this._message2;
    }

    public void SetMessage2(string startMsg)
    {
        this._message2 = startMsg;
    }
}