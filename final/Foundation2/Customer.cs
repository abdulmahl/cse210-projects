public class Customer
{
    private string _name = "";
    private Address _address;
    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public string Name()
    {
        return this._name;
    }

    public Address Address()
    {
        return this._address;
    }

    public bool GetCountry()
    {
        return this._address.GetCountry();
    }
}