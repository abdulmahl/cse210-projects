using System;
using static System.Console;

public class Sedan : Vehicle
{
    public Sedan(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public override string GetVINumber()
    {
        return "WBAAV33451EE76139";
    }

    public override int GetYear()
    {
        return 2022;
    }

    public override string GetEngineSize()
    {
        return "3.4 Litre";
    }

    public override string GetTransmission()
    {
        return "6 Speed DCT";
    }
}