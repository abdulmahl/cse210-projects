using System;
using static System.Console;

public class Vehicle
{
    protected string _type = "";
    protected string _make = "";
    protected string _model = "";
    protected string _viNumber = "";
    protected int _year = 0;
    protected string _engineSize = "";
    protected string _transmission = "";

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

    }

    public string GetBodyType()
    {
        return this._type;
    }

    public void SetBodyType()
    {
        Write("What vehicle type would you like to test-drive? ");
        _type = ReadLine();
    }

    public string GetMake()
    {
        return this._make;
    }

    public void SetMake()
    {
        Write($"What is the make of this {_type}? ");
        _make = ReadLine();
    }

    public string GetModel()
    {
        return this._model;
    }

    public void SetModel()
    {
        Write($"What model is this {_make}? ");
        _model = ReadLine();
    }

    public virtual string GetVINumber()
    {
        return this._viNumber;
    }

    public virtual int GetYear()
    {
        return this._year;
    }

    public virtual string GetEngineSize()
    {
        return this._engineSize;
    }

    public virtual string GetTransmission()
    {
        return this._transmission;
    }
}