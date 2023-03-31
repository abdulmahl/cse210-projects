using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        var dateOnly = new DateOnly();
        string formattedDate = dateOnly.ToString("April 15, 2023");

        var startTime = new TimeOnly(18, 00);
        var endTime = new TimeOnly(19, 30);

        Clear();
        WriteLine($"Hello and welcome to our events program.");
        Write("Loading");
        for (int i = 0; i < 8; i++)
        {
            Thread.Sleep(250);
            Write($".");
        }
        Clear();

        var address = new Address("At the Podium", "106 West Street", "Randburg", "South Africa");
        Lecture lectureDetails = new Lecture($"\"Exploring the Universe: A Journey through Space and Time\"","Prof. Lindi Kruger Astronomy and Astrophysics PhD", "Lecture", "Join us for an exciting evening as Prof. Lindi Kruger, a renowned astrophysicist,\ntakes us on a journey through space and time. From the birth of stars to the mysteries of\nblack holes, Prof. Kruger will explore some of the most fascinating phenomena in the universe.", formattedDate, startTime, endTime, address );
        WriteLine("Standard Details:");
        WriteLine("***********************************************************************************************");
        WriteLine($"{lectureDetails.GetStdDetails()}");
        WriteLine("***********************************************************************************************");

        WriteLine();

        WriteLine("Full Details:");
        WriteLine("***********************************************");
        WriteLine($"{lectureDetails.GetFullDetails()}");
        WriteLine("***********************************************");
        WriteLine();

        WriteLine("Short Description:");
        WriteLine("************************************************************************");
        WriteLine($"{lectureDetails.GetShortDescription()}");
        WriteLine("************************************************************************");
        WriteLine();
        // Reception receptionDetails = new Reception();
        // receptionDetails.GetStdDetails();
        // receptionDetails.GetFullDetails();
        // receptionDetails.GetShortDescription();

        // Gathering gatheringDetails = new Gathering();
        // gatheringDetails.GetStdDetails();
        // gatheringDetails.GetFullDetails();
        // gatheringDetails.GetShortDescription(); 
    }
}