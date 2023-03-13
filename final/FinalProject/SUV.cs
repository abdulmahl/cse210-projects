public class SUV : Vehicle
{
    public SUV(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber() // Land Rover Discovery
    {
        return "SALVA2AG0DH710610";
    }

    public override int GetYear()
    {
        return 2013;
    }

    public override string GetEngineSize()
    {
        return "2.5 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed AMT";
    }
}