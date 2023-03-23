using System;
using static System.Console;

public class Sedan : Vehicle
{
    public Sedan()
    : base()
    {
        
    }

    public string GetVINumber() // Lexus IS350
    {
        base._viNumber = "JT8BE262665000481";
        return base._viNumber;
    }

    public int GetYear()
    {
        base._year = 2006;
        return base._year;
    }

    public string GetEngineSize()
    {
        base. _engineSize = "1.8 Litre";
        return base._engineSize;
    }

    public string GetTransmission()
    {
        base._transmission = "6 Speed Manual";
        return base._transmission;
    }

    public override void GetVehicleSpecs(int number)
    {
        // WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        // WriteLine("------------------------------------------------");
        // WriteLine($"Body Type: {base._type}");
        // WriteLine($"Vin Number: {this.GetVINumber()}");
        // WriteLine($"Engine Size: {this.GetEngineSize()}");
        // WriteLine($"Transmission: {this.GetTransmission()}");
        // WriteLine($"Year of Make: {this.GetYear()}");
        // WriteLine("-------------------------------------------------");
    }

    public override void GetVehicle(int number)
    {
        // WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}, {base._type}");
    }

    public override string SaveToFile()
    {
        // return $"Sedan: {base._make}, {base._model}, {this.GetEngineSize()}, {this.GetTransmission()}, {base._testDrive}, {base._phoneNumber}, {base._date.ToShortDateString()}";
        return "";
    }

}