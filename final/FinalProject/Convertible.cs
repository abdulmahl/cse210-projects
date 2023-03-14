using static System.Console;

public class Convertible : Vehicle
{
    public Convertible(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public Convertible()
    : base()
    {
        
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
        return "2.8 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed IMT";
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