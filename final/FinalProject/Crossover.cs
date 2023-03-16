using static System.Console;

public class Crossover : Vehicle
{
    private string _windows = "";
    private string _display = "";

    public Crossover(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Crossover(string windows, string display)
    : base()
    {
        this._windows = windows;
        this._display = display;
    }

    public string GetWindows()
    {
        return this._windows;
    }

    public string GetDisplay()
    {
        return this._display;
    }

    public string GetVINumber() // Subaru Outback
    {
        return "4S4BSBDC5F3315222";
    }

    public int GetYear()
    {
        return 2015;
    }

    public string GetEngineSize()
    {
        return "2.0 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed Manual";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Windows: {this.GetWindows()}");
        WriteLine($"Display: {this.GetDisplay()}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine("-------------------------------------------------");
    }

    public override void GetVehicle(int number)
    {
        WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}, Crossover");
    }

    public override string SaveToFile()
    {
        return $"Crossover: {this._make},{this._model},{this.GetEngineSize()},{this.GetTransmission()},  {base._date}";
    }
}