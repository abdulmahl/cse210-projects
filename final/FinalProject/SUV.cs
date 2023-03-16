using static System.Console;
public class SUV : Vehicle
{
    private string _seatCapacity = "";
    public SUV(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public SUV(string seatCapacity)
    : base()
    {
        this._seatCapacity = seatCapacity;
    }

    public string GetSeatCapacity()
    {
        return this._seatCapacity;
    }

    public string GetVINumber() // Land Rover Discovery
    {
        return "SALVA2AG0DH710610";
    }

    public int GetYear()
    {
        return 2013;
    }

    public string GetEngineSize()
    {
        return "2.5 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed AMT";
    }

    public override void GetVehicleSpecs(int number)
    {
        WriteLine($"{number}. {base._make} {base._model} with the following specifications");
        WriteLine("------------------------------------------------");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Seat Capacity: {this.GetSeatCapacity()}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine("-------------------------------------------------\n");
    }

    public override void GetVehicle(int number)
    {
        WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}, SUV");
    }
}