using static System.Console;

public class Coupe : Vehicle
{
    public Coupe(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Coupe()
    : base()
    {
        
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
        WriteLine("************************************************");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine($"************************************************\n");
    }
}