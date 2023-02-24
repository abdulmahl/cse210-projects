using System;
using static System.Console;

public class CountDown
{

    private int _seconds = 0;

    public CountDown(int seconds)
    {
        _seconds = seconds;
    }

    public void GetCounter()
    {
        while (_seconds > 0) 
        {
            Write(_seconds);
            _seconds--;
            Thread.Sleep(1000);
            Write("\b \b");
        }
    }
}
