public class MiniVan : Vehicle
{
    public MiniVan(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber()  // Chrysler Town and Country
    {
        return "2C4PC1AG5DR790348";
    }

    public override int GetYear()
    {
        return 2013;
    }

    public override string GetEngineSize()
    {
        return "1.4 Litre";
    }

    public override string GetTransmission()
    {
        return "5 Speed Manual";
    }
}