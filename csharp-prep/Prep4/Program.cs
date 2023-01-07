using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Core Requirements...//
        List <int> numbers = new List<int> ();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to Quit): ");

            string userInput = Console.ReadLine();
            userNumber = int.Parse(userInput);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        float max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The maximum is: {max}");


        // Stretch Challenge...//
        int smallestNumber = 99999999;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestNumber)
            {
                smallestNumber = number;
            }
        }
        Console.WriteLine($"The smallest positive is: {smallestNumber}");

        numbers.Sort();
        Console.WriteLine("Sorted list:");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}