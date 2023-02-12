using System;
using static System.Console;

//  In a do while loop the Program displays the menu of options,
//  Instanciates the Journal and the PromptGenerator classes.
//  Invokes the funtionalities of the choices according to the 
//  choices made by the user.
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        
        string choice = "";
        do
        {
            WriteLine("Welcome to the Journal Program!");
            WriteLine("Please select one of the following choices");
            WriteLine("1. Write");
            WriteLine("2. Display");
            WriteLine("3. Load");
            WriteLine("4. Save");
            WriteLine("5. Quit");
            Write("What would you like to do? ");
            choice = ReadLine();

            if (choice == "1")
            {
                journal.AddEntry();
            }

            else if (choice == "2")
            {
                journal.DisplayEntry();
            }

            else if (choice == "3")
            {
                generator.loadFile();
            }

            else if (choice == "4")
            {
                generator.SaveToFile(journal.GetEntries());

            }

            else
            {
                break;
            }

        } while (choice != "5");
    }


}
