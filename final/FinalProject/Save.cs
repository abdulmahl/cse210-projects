using System;
using static System.Console;

public class SaveVehicle
{
    private bool _testDrive = false;
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
                if (_testDrive == true)
                {
                    sw.WriteLine($"{save.SaveToFile()}");       
                }

                else if (!_testDrive == true)
                {
                    sw.WriteLine($"{save.SaveToFileFalse()}");
                }
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
}
