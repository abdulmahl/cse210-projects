using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();
        WriteLine($"Hello and welcome to our events program.");
        Write("Loading");
        for (int i = 0; i < 8; i++)
        {
            Thread.Sleep(250);
            Write($".");
        }
        Clear();

        var dateOnly1 = new DateOnly();
        string formattedDate1 = dateOnly1.ToString("April 15, 2023");
        var startTime1 = new TimeOnly(18, 00);
        var endTime1 = new TimeOnly(20, 00);

        var addressLecture = new Address("At the Podium", "106 West Street", "Randburg", "South Africa");
        Lecture lectureDetails = new Lecture($"\"Exploring the Universe: A Journey through Space and Time\"", "Join us for an exciting evening as Prof. Lindi Kruger, a renowned astrophysicist,\ntakes us on a journey through space and time. From the birth of stars to the mysteries of\nblack holes, Prof. Kruger will explore some of the most fascinating phenomena in the universe.", formattedDate1, startTime1, endTime1, addressLecture, "Prof. Lindi Kruger Astronomy and Astrophysics PhD", 25, "Lecture");
        WriteLine("Standard Details: Lecture");
        WriteLine("***********************************************************************************************");
        WriteLine($"{lectureDetails.GetStdDetailsLecture()}");
        WriteLine("***********************************************************************************************");

        WriteLine();

        WriteLine("Full Details: Lecture");
        WriteLine("***********************************************************************************************");
        WriteLine($"{lectureDetails.GetFullDetailsLecture()}");
        WriteLine("***********************************************************************************************");

        WriteLine();

        WriteLine("Short Description: Lecture");
        WriteLine("************************************************************************");
        WriteLine($"{lectureDetails.GetShortDescriptionLecture()}");
        WriteLine("************************************************************************");
        WriteLine();

        var dateOnly2 = new DateOnly();
        string formattedDate2 = dateOnly2.ToString("Jul 04, 2023");
        var startTime2 = new TimeOnly(20, 00);
        var endTime2 = new TimeOnly(23, 00);

        var addressReception = new Address("Ninety II @ Revonia", "92 Revonia Street", "Sandton", "South Africa");
        Reception receptionDetails = new Reception($"\"Cocktails & Conversation: An Evening of Networking\"", "Cocktails & Conversation: An Evening of Networking is the perfect event for anyone looking to expand their professional circle, gain exposure to new ideas and trends, or simply enjoy an evening of good company and conversation. Guests are encouraged to mingle, exchange business cards, and strike up conversations with other attendees. The atmosphere is lively, yet sophisticated, creating an ideal setting for building relationships and exploring new opportunities.", formattedDate2, startTime2, endTime2, addressReception, "Reception", "scoltz223419@gui.io", "+27 76 600 1606");
        WriteLine("Standard Details: Reception");
        WriteLine("***************************************************************************************************");
        WriteLine(receptionDetails.GetStdDetailsReception());
        WriteLine("***************************************************************************************************");
        WriteLine();

        WriteLine("Full Details: Reception");
        WriteLine("****************************************************************************************************");
        WriteLine(receptionDetails.GetFullDetailsReception());
        WriteLine("****************************************************************************************************");
        WriteLine();

        WriteLine("Short Description: Reception");
        WriteLine("************************************************************************");
        WriteLine(receptionDetails.GetShortDescriptionReception());
        WriteLine("************************************************************************");
        WriteLine();

        var dateOnly3 = new DateOnly();
        string formattedDate3 = dateOnly3.ToString("Nov 24, 2023");
        var startTime3 = new TimeOnly(14, 00);
        var endTime3 = new TimeOnly(21, 00);

        var addressGathering = new Address("HM Pitje Stadium", "44 Corner Seluma & Fourth Street", "Mamelodi", "South Africa");
        Gathering gatheringDetails = new Gathering("\"Digital Marketing Summit\"", "The Digital Marketing Summit is a gathering event that brings together experts, thought leaders, and industry professionals to discuss the latest trends, strategies, and best practices in digital marketing. The summit provides an opportunity for attendees to learn from and network with some of the top minds in the industry.The event typically features keynote presentations, panel discussions, and workshops covering a range of topics such as search engine optimization (SEO), social media marketing, email marketing, content marketing, and analytics. Attendees can expect to gain valuable insights and practical advice on how to improve their digital marketing efforts and achieve better results.", formattedDate3, startTime3, endTime3, addressGathering, "Gathering");
        WriteLine("Standard Details: Gathering");
        WriteLine("***********************************************************************************************");
        WriteLine(gatheringDetails.GetStdDetailsGathering());
        WriteLine("***********************************************************************************************");
        WriteLine();
    
        WriteLine("Full Details: Gathering");
        WriteLine("************************************************************************************************");
        WriteLine(gatheringDetails.GetFullDetailsGathering());
        WriteLine("*************************************************************************************************");
        WriteLine();
    
        WriteLine("Short Description: Gathering");
        WriteLine("***********************************************");
        WriteLine(gatheringDetails.GetShortDescriptionGathering()); 
        WriteLine("***********************************************");
        WriteLine();
    }
}