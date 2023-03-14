using static System.Console;

public class Crossover : Vehicle
{
    public Crossover(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Crossover()
    : base()
    {
        
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
        WriteLine("************************************************");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine($"************************************************\n");
    }
}