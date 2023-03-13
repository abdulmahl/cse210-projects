public class SportsCar : Vehicle
{
    public SportsCar(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public string GetVINumber()
    {
        return "WBAAV33451EE76139";
    }

    public int GetYear() // BMW 3 Series 
    {
        return 2022;
    }

    public string GetEngineSize()
    {
        return "3.3 Litre";
    }

    public string GetTransmission()
    {
        return "6 Speed DCT";
    }
}