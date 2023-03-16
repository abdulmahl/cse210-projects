using static System.Console;

public class Convertible : Vehicle
{
    private string _roof = "";
    private string _seats = "";
    private string _horsePower = "";
    public Convertible(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Convertible(string roof, string seats, string horsePower)
    : base()
    {
        this._roof = roof;
        this._seats = seats;
        this._horsePower = horsePower;
    }

    string GetRoof()
    {
        return this._roof;
    }

    string GetSeats()
    {
        return this._seats;
    }

    string GetHorsePower()
    {
        return this._horsePower;
    }

    public string GetVINumber() // Mercedes-Benz SLK 
    {
        return "WDBKK65F61F198941";
    }

    public int GetYear()
    {
        return 2001;
    }

    public string GetEngineSize()
    {
        return "3.2 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed IMT";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Roof Type: {this.GetRoof()}");
        WriteLine($"Seat Material: {this.GetSeats()}");
        WriteLine($"Horse Power: {this.GetHorsePower()}");
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
        return $"Convertible: {this._make},{this._model},{this.GetEngineSize()},{this.GetTransmission()},  {base._date}";
    }
}