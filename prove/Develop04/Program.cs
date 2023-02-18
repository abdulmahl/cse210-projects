using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Breathing breathing = new Breathing("", "", "", "");
        Spinner spinner = new Spinner();
        // Reflecting reflecting = new Reflecting("", "", "");
        Listing listing = new Listing("", "", "", "");

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
                breathing.SetName("Breathing Activity.");
                breathing.SetDescription("This activity will help you ralax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathing.SetDuration("How long, in sceonds, would you like your session? ");

                string actName = breathing.GetName();
                string description = breathing.GetDescription();
                string duration = breathing.GetDuration();

                Clear();
                WriteLine($"Welcome to the {actName}\n");
                WriteLine($"{description}\n");
                Write(duration);
                Read();
                Clear();
                Write("Get ready...");

                spinner.Start();
                Thread.Sleep(5000); 
                spinner.Stop();
            }

            else if (choice == "2")
            {
                breathing.SetName("Reflecting Activity.");
                breathing.SetDescription("This activity will help you reflect on times in your life when you have demonstrated strength and resilience. This will help you recognize the power you have and how you can use in other aspects of your life.");
                breathing.SetDuration("How long, in sceonds, would you like your session? ");

                string actName = breathing.GetName();
                string description = breathing.GetDescription();
                string duration = breathing.GetDuration();

                Clear();
                WriteLine($"Welcome to the {actName}\n");
                WriteLine($"{description}\n");
                Write(duration);
                Read();
                Clear();
                Write("Get ready...");

                spinner.Start();
                Thread.Sleep(5000); 
                spinner.Stop();
            }

            else if (choice == "3")
            {
                breathing.SetName("Listing Activity.");
                breathing.SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                breathing.SetDuration("How long, in sceonds, would you like your session? ");

                string actName = breathing.GetName();
                string description = breathing.GetDescription();
                string duration = breathing.GetDuration();

                Clear();
                WriteLine($"Welcome to the {actName}\n");
                WriteLine($"{description}\n");
                Write(duration);
                Read();
                Clear();
                WriteLine("Get ready...");

                spinner.Start( );
                Thread.Sleep(2000); 
                spinner.Stop();

                WriteLine("List as many responses as you can to the following prompt:");
                listing.GetPrompt();
                ReadLine();

            }

            else
            {
                break;
            }
        }   
    }
}
