using static System.Console;

public class MiniVan : Vehicle
{
    public MiniVan(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public MiniVan()
    : base()
    {
        
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
        WriteLine("************************************************");
        WriteLine($"Body Type: {base._type}");
        WriteLine($"Vin Number: {this.GetVINumber()}");
        WriteLine($"Engine Size: {this.GetEngineSize()}");
        WriteLine($"Transmission: {this.GetTransmission()}");
        WriteLine($"Year of Make: {this.GetYear()}");
        WriteLine($"************************************************\n");
    }
}