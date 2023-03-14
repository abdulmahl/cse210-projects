using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        string option = "";
        string subOption = "";
        while (option != "5")
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
            option = ReadLine();

            switch (option)
            {
                case "1":
                    Clear();
                    WriteLine("The types of vehicles are");
                    WriteLine("  1. Sedans");
                    WriteLine("  2. Sports Cars");
                    WriteLine("  3. SUVs");
                    WriteLine("  4. Hatchbacks");
                    WriteLine("  5. Minivans");
                    WriteLine("  6. Convertibles");
                    WriteLine("  7. Coupes");
                    WriteLine("  8. Crossovers");
                    Write("Which vehicle type would you like to add? ");
                    subOption = ReadLine();
                    
                    switch (subOption)
                    {
                        case "1":
                            Clear();
                            var sedan = new Sedan();
                            vehicles.Add(sedan);
                        break;

                        case "2":
                            var sportsCar = new SportsCar();
                            vehicles.Add(sportsCar);
                        break;

                        case "3":
                        break;

                        case "4":
                        break;

                        case "5":
                        break;

                        case "6":
                        break;

                        case "7":
                        break;

                        case "8":
                        break;

                        default:
                        break;
                    
                    }   

                break;

                case "2":
                   
                break;

                case "3":
                    Write($"\nThe vehicles are");
                    int i = 0;
                    foreach (var vehicle in vehicles)
                    {
                        i++;
                        vehicle.GetVehicleSpecs(i);
                    }
                break;

                case "4":
                break;
                
                default:
                case "5":
                break;
            }            
        }
    }
}