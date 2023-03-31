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
        Lecture lectureDetails = new Lecture($"\"Exploring the Universe: A Journey through Space and Time\"", "Join us for an exciting evening as Prof. Lindi Kruger, a renowned astrophysicist,\ntakes us on a journey through space and time. From the birth of stars to the mysteries of\nblack holes, Prof. Kruger will explore some of the most fascinating phenomena in the universe.", formattedDate, startTime, endTime, address, "Prof. Lindi Kruger Astronomy and Astrophysics PhD", 25, "Lecture");
        WriteLine("Standard Details:");
        WriteLine("***********************************************************************************************");
        WriteLine($"{lectureDetails.GetStdDetailsLecture()}");
        WriteLine("***********************************************************************************************");

        WriteLine();

        WriteLine("Full Details:");
        WriteLine("***********************************************************************************************");
        WriteLine($"{lectureDetails.GetFullDetailsLecture()}");
        WriteLine("***********************************************************************************************");

        WriteLine();

        WriteLine("Short Description:");
        WriteLine("************************************************************************");
        WriteLine($"{lectureDetails.GetShortDescriptionLecture()}");
        WriteLine("************************************************************************");
        WriteLine();

        Reception receptionDetails = new Reception($"\"Cocktails & Conversation: An Evening of Networking\"", "Cocktails & Conversation: An Evening of Networking is the perfect event for anyone looking to expand their professional circle, gain exposure to new ideas and trends, or simply enjoy an evening of good company and conversation. Guests are encouraged to mingle, exchange business cards, and strike up conversations with other attendees. The atmosphere is lively, yet sophisticated, creating an ideal setting for building relationships and exploring new opportunities.", formattedDate, startTime, endTime, address, "Reception", "scoltz223419@gui.io", "+27 76 600 1606");
        receptionDetails.GetStdDetailsReception();
        receptionDetails.GetFullDetailsReception();
        receptionDetails.GetShortDescriptionReception();

        // Gathering gatheringDetails = new Gathering();
        // gatheringDetails.GetStdDetails();
        // gatheringDetails.GetFullDetails();
        // gatheringDetails.GetShortDescription(); 
    }
}