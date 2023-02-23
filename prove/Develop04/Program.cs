using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();
        var choice = "";
        while (choice != "4")
        {
            WriteLine("Menu options:");
            WriteLine("  1.Start breathing actvity");
            WriteLine("  2.Start reflecting activity");
            WriteLine("  3.Start listing activity");
            WriteLine("  4. Quit ");
            Write("Select a choice from the menu: ");
            choice = ReadLine();

            if (choice == "1")
            {
                var _breathing = new Breathing();
                _breathing.ShowBreathingActivity();
            }

            else if (choice == "2")
            {
                var _reflecting = new Reflecting();
                _reflecting.ShowReflectingActivity();
            }

            else if (choice == "3")
            {
                var _listing = new Listing();
              _listing.ShowListingActivity();
            }

            else
            {
                Clear();
                break;
            }
        }   
    }
}
