public class Address
{
    private string _streetAddress = "";
    private string _city = "";
    private string _state = "";
    private int _areaCode;
    private string _country = "";
    public Address(string streetAddress, string city, string state,int areaCode, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._state = state;
        this._areaCode = areaCode;
        this._country = country;
    }

    public Address()
    {

    }

    public string GetFullAddress()
    {
        return $"{this._streetAddress}\n       {this._city}\n       {this._state}\n       \n{this._areaCode}       \n{this._country}.";
    }
}