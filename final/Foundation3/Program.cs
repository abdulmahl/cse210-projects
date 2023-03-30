using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateOnly = DateTime.Now.Date;
        string formattedDate = dateOnly.ToString("April 15, yyyy");

        var startTime = new TimeOnly(18, 00);
        var endTime = new TimeOnly(19, 30);

        Clear();
        WriteLine($"Hello and welcome to our events program.");
        Write("Loading");
        for (int i = 0; i < 8; i++)
        {
            Thread.Sleep(250);
            Write(".");
        }

        int choice = 0;
        while (choice != 4)
        {
            Clear();
            WriteLine("Select desired details to display");
            WriteLine("  1. Lecture Details");
            WriteLine("  2. Reception Details");
            WriteLine("  3. Gathering Details");
            WriteLine("  4. Return");
            Write("Select details to display ");
            choice = int.Parse(ReadLine());

            switch (choice)
            {
                case 1:
                    var address = new Address("At the Podium", "106 West Street", "Randburg", "South Africa");
                    Lecture lectureDetails = new Lecture("\"Exploring the Universe: A Journey through Space and Time\"", "Lecture", "Join us for an exciting evening as Prof. Lindi Kruger, a renowned astrophysicist,\ntakes us on a journey through space and time. From the birth of stars to the mysteries of\nblack holes, Dr. Smith will explore some of the most fascinating phenomena in the universe.", DateTime.Now, startTime, address );
                    WriteLine($"{lectureDetails.GetStdDetails()}");
                    WriteLine($"{lectureDetails.GetFullDetails()}");
                    WriteLine($"{lectureDetails.GetShortDescription()}");
                break;

                case 2:
                    // Reception receptionDetails = new Reception();
                    // receptionDetails.GetStdDetails();
                    // receptionDetails.GetFullDetails();
                    // receptionDetails.GetShortDescription();
                break;

                case 3:
                    // Gathering gatheringDetails = new Gathering();
                    // gatheringDetails.GetStdDetails();
                    // gatheringDetails.GetFullDetails();
                    // gatheringDetails.GetShortDescription();
                break;
            
                default:
                    Clear();
                break;
            }
        }
    }
}