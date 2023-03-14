using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();

        void ShowMenu()
        {
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


            switch (option)
            {
                case 1:
                    int subOption = 0;
                    ShowSubMenu();
                    subOption = int.Parse(ReadLine());
                    
                    switch (subOption)
                    {
                        case 1:
                            Clear();
                            var sedan = new Sedan();
                            vehicles.Add(sedan);
                        break;

                        case 2:
                        WriteLine();
                            var sportsCar = new SportsCar("Leather", "24\" Allow");
                            vehicles.Add(sportsCar);
                        break;

                        case 3:
                            var suv = new SUV("7 Seater");
                            vehicles.Add(suv);
                        break;

                        case 4:
                            var hatch = new Hatchback("Electric", "Pin on Top");
                            vehicles.Add(hatch);
                        break;

                        case 5:
                            var miniVan = new MiniVan();
                            vehicles.Add(miniVan);
                        break;

                        case 6:
                            var convertible = new Convertible();
                            vehicles.Add(convertible);
                        break;

                        case 7:
                            var coupe = new Coupe();
                            vehicles.Add(coupe);
                        break;

                        case 8:
                            var crossOver = new Crossover();
                            vehicles.Add(crossOver);
                        break;

                        default:
                        break;
                    
                    }   

                break;

                case 2:
                   
                break;

                case 3:
                    Clear();
                    int i = 0;
                    Write($"\nThe vehicles are:\n");
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