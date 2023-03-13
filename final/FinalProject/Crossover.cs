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
}