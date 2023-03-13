public class SportsCar : Vehicle
{
    public SportsCar(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber()
    {
        return "WBAAV33451EE76139";
    }

    public override int GetYear() // BMW 3 Series 
    {
        return 2022;
    }

    public override string GetEngineSize()
    {
        return "3.3 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed DCT";
    }
}