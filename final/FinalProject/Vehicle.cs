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
    protected string _phoneNumber;
    protected bool _testDrive = false;

    public Vehicle()
    {
        Write("What vehicle type would you like to test-drive? ");
        this._type = ReadLine();
        Write($"What is the make of this {this._type}? ");
       this. _make = ReadLine();
        Write($"What model is this {this._make}? ");
        this._model = ReadLine();
        Write("Would you like to book a test drive? ");
        string input = ReadLine();
            if (input == "Yes")
            {
                _testDrive = true;
                Write($"On which day would you like to test-drive this {this._make} {this._model}? ");
                this._date = DateTime.Parse(ReadLine());
                Write("Please enter your phone number? ");
                _phoneNumber = ReadLine();
            }
            else if (input == "No")
            {
                Clear();
                return;
            }
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

    public virtual string SaveToFile()
    {
        return $"{this._make},{this._model},{this._type},{this._engineSize},{this._transmission}, {this._date.ToShortDateString()}";
    }
}