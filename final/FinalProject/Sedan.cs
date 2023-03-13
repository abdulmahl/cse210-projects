using System;
using static System.Console;

public class Sedan : Vehicle
{
    public Sedan(string type, string make, string model, string viNumber, int year, string engineSize, string transmission) 
    : base(type, make, model, viNumber, year, engineSize, transmission)
    {

    }

    public string GetVINumber() // Lexus IS350
    {
        base._viNumber = "JT8BE262665000481";
        return base._viNumber;
    }

    public int GetYear()
    {
        base._year = 2006;
        return base._year;
    }

    public string GetEngineSize()
    {
        base. _engineSize = "1.8 Litre";
        return base._engineSize;
    }

    public string GetTransmission()
    {
        base._transmission = "6 Speed Manual";
        return base._transmission;
    }

    public override void GetVehicleSpecs(int number)
    {
        string specs = $"{base.GetMake()} {base.GetModel()}, {base.GetBodyType()} Vin Number: {this.GetVINumber()} Engine Size: {this.GetEngineSize()} Transmission: {this.GetTransmission()}";
        WriteLine($"{number}. {specs} {this.GetYear()}");
    }

    public override void GetSpecs(int number)
    {
        WriteLine($"{number}. {base.GetMake()} {base.GetModel()} {this.GetYear()}");
    }

    public override string SaveToFile()
    {
        return $"Sedan: {this._make},{this._model},{this._type},{this.GetEngineSize()},{this.GetTransmission()},{this._tested}";
    }
}