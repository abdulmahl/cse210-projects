using System;
using static System.Console;
using System.Diagnostics;



class Program
{
    static void Main(string[] args)
    {
        string text = "Lorem ipsum dolor...";

        for (int i = 1; i <= text.Length; i++)
        {
            Console.Write(text.Substring(0, i));
            Thread.Sleep((int)(1000 * Math.Pow(1.1, -i)));
        }

        Console.ReadLine();
    }
}
