using System;

public class Activity
{
    private string _activityName;
    private string _description;
    private string _durationSeconds;
    private string _endMessage;

    public Activity(string actName, string description, string duration, string endMsg)
    {
        _activityName = actName;
        _description = description;
        _durationSeconds = duration;
        _endMessage = endMsg;
    }

    public string GetName()
    {
        return _activityName;
    }

    public void SetName(string actName)
    {
        _activityName = actName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }
    public string GetDuration()
    {
        return _durationSeconds;
    }

    public void SetDuration(string seconds)
    {
        _durationSeconds = seconds;
    }

    public string GetMessage()
    {
        return _endMessage;
    }

    public void SetMessage(string endMsg)
    {
        _endMessage = endMsg;
    }
}