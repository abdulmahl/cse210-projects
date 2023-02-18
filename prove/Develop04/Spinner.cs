using System;

public class Spinner
{
    private int _currentFrame = 0;
    private char[] _frames = {'|', '/', '-', '\\'};
    private bool _active = false;

    public Spinner() 
    {

    }

    public void Start()
    {
        _active = true;
        Thread spinnerThread = new Thread(Spin);
        spinnerThread.Start();
    }

    public void Stop()
    {
        _active = false;
    }

    private void Spin()
    {
        while (_active)
        {
            Console.Write(_frames[_currentFrame]);
            _currentFrame = (_currentFrame + 1) % _frames.Length;
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(500);
        }
    }
}