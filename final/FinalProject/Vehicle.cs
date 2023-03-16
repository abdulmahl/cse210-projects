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
    
    public Vehicle(DateTime date)
    {
        Write("What is the name of the file? ");
        var fileName = ReadLine();
        using (StreamWriter sw = new StreamWriter(fileName))
        {
            sw.WriteLine($"{date}");
            sw.WriteLine($"Sedan: {this._make},{this._model},{this._type}");
        }
    }

    public string GetMake()
    {
        return this._make;
    }

    public string GetModel()
    {
        return this._model;
    }

    public void SetDateTime()
    {
    }

    public virtual void GetVehicleSpecs(int number)
    {
        string specs =  $"Make and Model: {this._make} {this._model} Body Type: {this._type} Vin Number: {this._viNumber} Engine Size: {this._engineSize} Transmission: {this._transmission}";
        WriteLine($"{number}. {specs} Year of Make: {this._year}");
    }

    public virtual void GetVehicle(int number)
    {
        string specs = $"{this._make} {this._model} {this._year}";
        WriteLine($"{number}. {specs}");
    }

    public virtual void SaveToFile(DateTime date)
    {
        WriteLine(date);
        WriteLine($"{this._make},{this._model},{this._type},{this._engineSize},{this._transmission}");
    }
}