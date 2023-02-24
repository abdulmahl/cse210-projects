using System;
using static System.Console;

public class Spinner
{
    public Spinner() 
    {

    }

    public void GetSpinner()
    {
        int spin = 0;
        while (spin != 3)
        {
            Write("|");
            Thread.Sleep(500);
            Write("\b \b");
            Write("/");
            Thread.Sleep(500);
            Write("\b \b");
            Write("-");
            Thread.Sleep(500);
            Write("\b \b");
            Write("\\");
            Thread.Sleep(500);
            Write("\b \b");
            spin += 1;
        }
    }
}