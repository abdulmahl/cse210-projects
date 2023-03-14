using System;
using static System.Console;

public abstract class Vehicle
{
    protected string _type = "";
    protected string _make = "";
    protected string _model = "";
    protected string _viNumber = "";
    protected int _year = 0;
    protected string _engineSize = "";
    protected string _transmission = "";
    protected DateTime _date;
    protected bool _tested = false;


    public Vehicle(string type, string make, string model, string viNumber, int year, string engineSize, string transmission)
    {
        this._type = type;
        this._make = make;
        this._model = model;
        this._viNumber = viNumber;
        this._year = year;
        this._engineSize = engineSize;
        this._transmission = transmission;
    }

    public Vehicle()
    {
        Write("What vehicle type would you like to test-drive? ");
        _type = ReadLine();
        Write($"What is the make of this {this._type}? ");
        _make = ReadLine();
        Write($"What model is this {this._make}? ");
        _model = ReadLine();
        Write($"On which day would you like to test-drive this {this._make} {this._model}? ");
        _date = DateTime.Parse(ReadLine());
        Clear();
    }

    public string GetMake()
    {
        return this._make;
    }

    public string GetModel()
    {
        return this._model;
    }

    public DateTime GetDateTime()
    {
        return this._date;
    }

    public void SetDateTime()
    {
    }

    public virtual void GetVehicleSpecs(int number)
    {
        string specs =  $"Make and Model: {this._make} {this._model}\nBody Type: {this._type}\nVin Number: {this._viNumber}\nEngine Size: {this._engineSize}\nTransmission: {this._transmission}";
        WriteLine($"{number}. {specs}\nYear of Make: {this._year}");
    }

    public virtual void GetSpecs(int number)
    {
        string specs = $"{this._make} {this._model} {this._year}";
        WriteLine($"{number}. {specs}");
    }

    public virtual string SaveToFile()
    {
        return $"{this._make},{this._model},{this._type},{this._engineSize},{this._transmission},{this._tested}";
    }
}