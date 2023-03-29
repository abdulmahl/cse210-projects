using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();

        var events = new Events();
        var addressLecture = new Address("106 West Street", "Randburg", "Gauteng", 1098, "South Africa");
        var lecture = new Lecture();
        lecture.SetSpeaker("Prof. Lindi Kruger Phd"); lecture.SetCapacity(15);
        WriteLine($"Lecturer Name: {lecture.GetSpeaker()}\nLimited Capacity: {lecture.GetCapacity()} Attendees");
        WriteLine($"\nVenue: {addressLecture.GetFullAddress()}");
        WriteLine($"");
    }
}