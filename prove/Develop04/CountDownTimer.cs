using System;
using System.Threading;

public class CountDown
{
    private double _countDown;
    public CountDown(double countDown)
    {
        _countDown = countDown;
    }

    public double CountDownSeconds()
    {
        while (_countDown > 0)
        {
            Thread.Sleep(1000);
            Console.WriteLine(_countDown);
        }
        return  _countDown--;
    }
}