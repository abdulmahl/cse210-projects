public class Product
{
    string _name = "";
    string _productId = "";
    decimal _price = 0;
    int _quantity = 0;
    public Product(string name, string productId, decimal price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this._price = price;
        this._quantity = quantity;
    }

    public string GetProductLabel()
    {
        return $"{this._name}\t\t{this._productId}\t\t${this._price}\t\t{this._quantity}";
    }

    public decimal GetTotal()
    {
        return this._price * this._quantity;
    }
}