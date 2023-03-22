using static System.Console;

public class Hatchback : Vehicle
{
    private string _windows = "";
    private string _roof = "";

    public Hatchback(string windows, string roof)
    : base()
    {
        this._windows = windows;
        this._roof = roof;
    }

    public string GetWindows()
    {
        return this._windows;
    }

    public string GetRoof()
    {
        return this._roof;        
    }

    public string GetVINumber()  // Volvo V60
    {
        return "YV140MEB0F1195985";
    }

    public int GetYear()
    {
        return 2015;
    }

    public string GetEngineSize()
    {
        return "1.8 Litre";
    }

    public string GetTransmission()
    {
        return "5 Speed AT";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Windows: {this.GetWindows()}");
        WriteLine($"Roof: {this.GetRoof()}");
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
        return $"Hatchback: {base._make}, {base._model}, {this.GetEngineSize()}, {this.GetTransmission()}, {base._testDrive}, {base._phoneNumber}, {base._date.ToShortDateString()}";
    }
}