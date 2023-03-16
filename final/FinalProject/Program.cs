using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        DateTime date = DateTime.Now;

        int option = 0;
        while (option != 5)
        {
            var show = new SaveVehicle();
            show.ShowMenu();
            option = int.Parse(ReadLine());

            switch (option)
            {
                case 1:
                    int subOption = 0;
                    show.ShowSubMenu();
                    subOption = int.Parse(ReadLine());
                    
                    switch (subOption)
                    {
                        case 1:
                            Clear();
                            var sedan = new Sedan();
                            vehicles.Add(sedan);
                        break;

                        case 2:
                            Clear();
                            var sportsCar = new SportsCar("Leather", "24\" Allow");
                            vehicles.Add(sportsCar);
                        break;

                        case 3:
                            Clear();
                            var suv = new SUV("7 Seater");
                            vehicles.Add(suv);
                        break;

                        case 4:
                            Clear();
                            var hatch = new Hatchback("Electric", "Pin on Top");
                            vehicles.Add(hatch);
                        break;

                        case 5:
                            Clear();
                            var miniVan = new MiniVan("4 Door with Sliding Side Door ");
                            vehicles.Add(miniVan);
                        break;

                        case 6:
                            Clear();
                            var convertible = new Convertible("Leather Roof", "Ostrich Leather Seats", "600 HP");
                            vehicles.Add(convertible);
                        break;

                        case 7:
                            Clear();
                            var coupe = new Coupe("Lucid Red", "All Wheel Drive", "Front Engine");
                            vehicles.Add(coupe);
                        break;

                        case 8:
                            Clear();
                            var crossOver = new Crossover("Tinted Windows", "8\" LCD Retina Display");
                            vehicles.Add(crossOver);
                        break;

                        default:
                        break;
                    
                    }   

                break;

                case 2:
                    Clear();
                    int i = 0;
                    WriteLine($"\nThe vehicles are:\n");
                    foreach (var vehicle in vehicles)
                    {
                        i++;
                        vehicle.GetVehicleSpecs(i);
                    }
                    WriteLine();
                break;

                case 3:
                    Clear();
                    int j = 0;
                    WriteLine($"\nThe listed vehicles are:");
                    foreach (var vehicle in vehicles)
                    {
                        j++;
                        vehicle.GetVehicle(j);
                    }
                    WriteLine();
                break;

                case 4:
                    var save = new SaveVehicle();
                    save.Save(vehicles, date);
                break;
                
                default:
                break;
            }            
        }
    }
}