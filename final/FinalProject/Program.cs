using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        void ShowMenu()
        {
            Clear();
            WriteLine($"Select one of the following menu options");
            WriteLine("  1. Enter Vehicle Details");
            WriteLine("  2. Get Vehicle Description");
            WriteLine("  3. List Entered Vehicles");
            WriteLine("  4. Save Listed Vehicles");
            WriteLine("  5. Exit");
            Write("What would you like to do? ");
        }

        void ShowSubMenu()
        {
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
            Write("Which vehicle would you like to add? ");
        }

        int option = 0;
        while (option != 5)
        {
            ShowMenu();
            option = int.Parse(ReadLine());
            Clear();


            switch (option)
            {
                case 1:
                    int subOption = 0;
                    ShowSubMenu();
                    subOption = int.Parse(ReadLine());
                    Clear();
                    
                    switch (subOption)
                    {
                        case 1:
                            Clear();
                            var sedan = new Sedan();
                            vehicles.Add(sedan);
                        break;

                        case 2:
                        WriteLine();
                            var sportsCar = new SportsCar();
                            vehicles.Add(sportsCar);
                        break;

                        case 3:
                        break;

                        case 4:
                        break;

                        case 5:
                        break;

                        case 6:
                        break;

                        case 7:
                        break;

                        case 8:
                        break;

                        default:
                        break;
                    
                    }   

                break;

                case 2:
                   
                break;

                case 3:
                    Write($"\nThe vehicles are");
                    int i = 0;
                    foreach (var vehicle in vehicles)
                    {
                        i++;
                        vehicle.GetVehicleSpecs(i);
                    }
                break;

                case 4:
                break;
                
                default:
                break;
            }            
        }
    }
}