public class Crossover : Vehicle
{
    public Crossover(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber() // Subaru Outback
    {
        return "4S4BSBDC5F3315222";
    }

    public override int GetYear()
    {
        return 2015;
    }

    public override string GetEngineSize()
    {
        return "2.0 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed Manual";
    }
}