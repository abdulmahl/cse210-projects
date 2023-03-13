public class Convertible : Vehicle
{
    public Convertible(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber() // Mercedes-Benz SLK 
    {
        return "WDBKK65F61F198941";
    }

    public override int GetYear()
    {
        return 2001;
    }

    public override string GetEngineSize()
    {
        return "2.8 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed IMT";
    }
}