using System;
using static System.Console;

public class SaveVehicle
{
    public SaveVehicle()
    {

    }

    public void Save(List<Vehicle> vehicles)
    {
        Write("What is the name of the file? ");
        string fileName = ReadLine();
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            foreach (var save in vehicles)
            {
                sw.WriteLine($"{save.SaveToFile()}");       
            } 
        }
    }

    public void ShowMenu()
    {
        WriteLine($"Select one of the following menu options");
        WriteLine("  1. Enter Vehicle Details");
        WriteLine("  2. Get Vehicle Description");
        WriteLine("  3. List Entered Vehicles");
        WriteLine("  4. Save Listed Vehicles");
        WriteLine("  5. Exit");
        Write("What would you like to do? ");
    }

    public void ShowSubMenu()
    {
        Write($"The types of vehicles are\n");
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
}