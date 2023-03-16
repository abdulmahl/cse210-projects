using System;
using static System.Console;

public class SaveVehicle
{
    public SaveVehicle()
    {

    }

    public void Save(List<Vehicle> vehicles, DateTime date)
    {
        Write("What is the name of the file? ");
        string fileName = ReadLine();
        using (StreamWriter sw = new StreamWriter(fileName, true))
        {
            sw.WriteLine(date);                    
            foreach (var save in vehicles)
            {
                sw.WriteLine($"{save.SaveToFile()}");
            } 
        }
    }
}
