using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            WriteLine($"    Online Test Drive Boooking");
            WriteLine($"Select one of the following menu options");
            WriteLine("  1. Enter Vehicle Details");
            WriteLine("  2. List Entered Vehicles");
            WriteLine("  3. Save Listed Vehicles");
            WriteLine("  4. Exit");
            Write("What would you like to do? ");
            option = int.Parse(ReadLine());

            Clear();

            switch (option)
                {
                    case 1:
                        var vehicle = new Vehicle();
                            vehicle.SetBodyType();
                            vehicle.SetMake();
                            vehicle.SetModel();
                    break;

                    case 2:
                    break;

                    case 3:
                    break;
                    
                    default:
                    break;
                }            
        } while (option != 4);
    }
}