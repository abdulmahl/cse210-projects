using System;
using static System.Console;

class Program
{
    List<Vehicle> vehicles = new List<Vehicle>();
    static void Main(string[] args)
    {
        int option = 0;
        do
        {
            Clear();
            WriteLine($"This is the Online Test Drive Boooking Program");
            WriteLine($"Select one of the following menu options");
            WriteLine("  1. Enter Vehicle Details");
            WriteLine("  2. Get Vehicle Description");
            WriteLine("  3. List Entered Vehicles");
            WriteLine("  4. Save Listed Vehicles");
            WriteLine("  5. Exit");
            Write("What would you like to do? ");
            option = int.Parse(ReadLine());

            switch (option)
                {
                    case 1:
                    var sedan = new Vehicle();
                        sedan.SetBodyType();
                        sedan.SetMake();
                        sedan.SetModel();
                        sedan.SetDateTime();
                    break;

                    case 2:
                  
                    break;

                    case 3:
                    break;

                    case 4:
                    break;
                    
                    default:
                    break;
                }            
        } while (option != 5);
    }
}