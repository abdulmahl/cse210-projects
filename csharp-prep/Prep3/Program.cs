using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("We are going to play a magic number guessing game, if your guess is higher than the maic number, you will be prompted to guess lower and if it's lower you will be prompted to guess lower");
        Console.WriteLine("GOOO LUCk");

        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);
        // Console.WriteLine(magicNumber);

        int guessCount = 0;
        int guess = -1; 

        string playAgain = "yes";
        do
        {
            do
            {

            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            guessCount += 1;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }

            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }

            else
            {   
                Console.WriteLine("You guessed it!!!");
                

            if (guessCount == 1)
            {
                Console.WriteLine($"It took you {guessCount} guess.");
            }

            else if (guessCount >= 2)
            {
                Console.WriteLine($"It took you {guessCount} guesses.");
            }

            Console.Write("Would you like play again? (Yes/No) ");
            playAgain = Console.ReadLine();
            if (playAgain == "no")
            {
                Console.WriteLine("Thank you for playing! Goodbye");
            }
        
            }
            
            } while (guess != magicNumber);

        magicNumber = randomGenerator.Next(1,101);
        // Console.WriteLine(magicNumber);

        } while (playAgain == "yes");
       
    }
}