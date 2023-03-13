public class Coupe : Vehicle
{
    public Coupe(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber() // Aston Martin Vanquish
    {
        return "SCFPDCGP4EGK01312";
    }

    public override int GetYear()
    {
        return 2014;
    }

    public override string GetEngineSize()
    {
        return "3.0 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed CVT";
    }
}