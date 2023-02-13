using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {

        Assignment assign = new Assignment("Samuel Bennett", "Multiplication");
        WriteLine($"{assign.GetSummary()}");

        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WriteLine($"{math.GetHomeworkList()}");

        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Cause of World war II");
        WriteLine(writing.GetSummary());
        WriteLine(writing.GetWritingInfo());
    }
}