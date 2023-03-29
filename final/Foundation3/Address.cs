public class Address
{
    private string _venue = "";
    private string _streetAddress = "";
    private string _city = "";
    private string _country = "";
    public Address(string venue, string streetAddress, string city, string country)
    {
        this._venue = venue;
        this._streetAddress = streetAddress;
        this._city = city;
        this._country = country;
    }

    public Address()
    {

    }

    public string GetFullAddress()
    {
        return $"{this._venue}, {this._streetAddress}, {this._city}, {this._country}";
    }
}