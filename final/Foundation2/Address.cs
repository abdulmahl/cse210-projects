using System.Text;

public class Address
{
    private string _address = "";
    private string _city = "";
    private string _state = "";
    private string _country = "";
    public Address(string address, string city, string state, string country)
    {
        this._address = address;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    public bool GetCountry()
    {
       return this._country.Equals("USA");
    }

    public string GetFullAddress()
    {
        var fullAddress = new StringBuilder();
        fullAddress.AppendLine($"{this._address}, {this._city}\n{this._state}, {this._country}");
        return fullAddress.ToString();
    }
}