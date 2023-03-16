using static System.Console;

public class Coupe : Vehicle
{
    private string _color = "";
    private string _wheelDrive = "";
    private string _enginePlace = "";
    public Coupe(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Coupe(string color, string wheelDrive, string enginePlace)
    : base()
    {
        this._color = color;
        this._wheelDrive = wheelDrive;
        this._enginePlace = enginePlace;
    }

    string GetColor()
    {
        return this._color;
    }

    string GetWheelDrive()
    {
        return _wheelDrive;
    }

    string GetEnginePlace()
    {
        return this._enginePlace;
    }

    public string GetVINumber() // Aston Martin Vanquish
    {
        return "SCFPDCGP4EGK01312";
    }

    public int GetYear()
    {
        return 2014;
    }

    public string GetEngineSize()
    {
        return "3.0 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed CVT";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Body Color: {this.GetColor()}");
        WriteLine($"Wheel Drive: {this.GetWheelDrive()}");
        WriteLine($"Engine Place: {this.GetEnginePlace()}");
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
        return $"Coupe: {this._make},{this._model},{this.GetEngineSize()},{this.GetTransmission()},  {base._date}";
    }
}