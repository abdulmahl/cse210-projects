public class Hatchback : Vehicle
{
    public Hatchback(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber()  // Volvo V60
    {
        return "YV140MEB0F1195985";
    }

    public override int GetYear()
    {
        return 2015;
    }

    public override string GetEngineSize()
    {
        return "1.8 Litre";
    }

    public override string GetTransmission()
    {
        return "5 Speed AT";
    }
}