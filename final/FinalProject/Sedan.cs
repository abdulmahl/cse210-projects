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
        base._viNumber = "JT8BE262665000481";
        return base._viNumber;
    }

    public override int GetYear()
    {
        base._year = 2006;
        return base._year;
    }

    public override string GetEngineSize()
    {
       base. _engineSize = "1.8 Litre";
        return base._engineSize;
    }

    public override string GetTransmission()
    {
        base._transmission = "6 Speed Manual";
        return base._transmission;
    }
}