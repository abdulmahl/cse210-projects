using static System.Console;
public class SportsCar : Vehicle
{
    private string _seats = "";
    private string _wheels = "";
    public SportsCar(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public SportsCar(string seats, string wheels)
    : base()
    {
        this._seats = seats;
        this._wheels = wheels;
    }

    string GetSeats()
    {
        return this._seats;
    }

    string GetWheels()
    {
        return this._wheels;
    }

    public string GetVINumber()
    {
        return "WBAAV33451EE76139";
    }

    public int GetYear() // BMW 3 Series 
    {
        return 2022;
    }

    public string GetEngineSize()
    {
        return "3.3 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed DCT";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("************************************************");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Seat Material: {this.GetSeats()}");
        WriteLine($"Mag Wheels: {this.GetWheels()}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine($"************************************************\n");
    }

    public override void GetVehicle(int number)
    {
        WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}, Sports Car");
    }
}