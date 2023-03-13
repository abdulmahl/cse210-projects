using System;
using static System.Console;

public class Sedan : Vehicle
{
    public Sedan(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber() // Lexus IS350
    {
        return "JT8BE262665000481";
    }

    public override int GetYear()
    {
        return 2006;
    }

    public override string GetEngineSize()
    {
        return "1.8 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed Manual";
    }
}