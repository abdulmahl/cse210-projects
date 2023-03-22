using static System.Console;

public class MiniVan : Vehicle
{
    private string _doors = "";
    
    public MiniVan(string doors)
    : base()
    {
        this._doors = doors;
    }

    public string GetDoors()
    {
        return this._doors;
    }

    public string GetVINumber()  // Chrysler Town and Country
    {
        return "2C4PC1AG5DR790348";
    }

    public int GetYear()
    {
        return 2013;
    }

    public string GetEngineSize()
    {
        return "1.4 Litre";
    }

    public string GetTransmission()
    {
        return "5 Speed Manual";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Doors: {this.GetDoors()}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine("-------------------------------------------------");
    }

    public override void GetVehicle(int number)
    {
        WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}, {base._type}");
    }

    public override string SaveToFile()
    {
        return $"Minivan: {base._make},{base._model},{this.GetEngineSize()},{this.GetTransmission()},  {base._date.ToShortDateString()}";
    }
}