using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();

        DateTime dateOnly = DateTime.Now.Date;
        string formattedDate = dateOnly.ToString("April 15, yyyy");

        WriteLine($"");
        var events = new Events();
        var addressLecture = new Address("At the Podium", "106 West Street", "Randburg", "South Africa");
        var lecture = new Lecture();
        lecture.SetEventTitle("\"Exploring the Universe: A Journey through Space and Time\"");
        WriteLine($"Title: {lecture.GetEventTitle()}");
        lecture.SetSpeaker("Prof. Lindi Kruger, Phd"); lecture.SetCapacity(15);
        WriteLine($"Speaker: {lecture.GetSpeaker()}\nLimited Capacity: {lecture.GetCapacity()} Attendees");
        WriteLine($"Date: {formattedDate}");
        WriteLine($"\nLocation: {addressLecture.GetFullAddress()}\n");
        WriteLine($"");
    }
}


// Title: "Exploring the Universe: A Journey through Space and Time"
// Speaker: Dr. Jane Smith, Astrophysicist
// Date: April 15, 2023
// Time: 7:00 pm - 8:30 pm
// Location: XYZ Auditorium, 123 Main Street, Anytown, USA

// Description:
// Join us for an exciting evening as Dr. Jane Smith, a renowned astrophysicist, takes us on a journey through space and time. From the birth of stars to the mysteries of black holes, Dr. Smith will explore some of the most fascinating phenomena in the universe. Using stunning images and interactive demonstrations, she will explain how we have come to understand the vastness of our cosmos and the many unanswered questions that remain. This event is free and open to the public. Don't miss this opportunity to learn more about the wonders of our universe!



