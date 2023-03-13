using System;
using static System.Console;

public class Vehicle
{
    private string _type = "";
    private string _make = "";
    private string _model = "";
    private string _viNumber = "";
    private int _year = 0;
    private string _engineSize = "";
    private string _transmission = "";

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

    public string GetTypeVehicle()
    {
        return this._type;
    }

    public string GetMake()
    {
        return this._make;
    }

    public void SetTypeVehicle()
    {
        Write("What vehicle type would you like to test-drive? ");
        _type = ReadLine();
    }

    public string GetModel()
    {
        return this._model;
    }

    string GetVINumber()
    {
        return this._viNumber;
    }

    int GetYear()
    {
        return this._year;
    }

    string GetEngineSize()
    {
        return this._engineSize;
    }

    string GetTransmission()
    {
        return this._transmission;
    }
}