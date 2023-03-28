using System.Text;

public class Order
{
    private Product[] _products;
    private Customer _customer;
    private decimal shippingCost;

    public Order(Product[] products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public string GetPackingLabel()
    {
        int i = 0;
        var packingLabel = new StringBuilder();
        packingLabel.AppendLine($"\nItem Name:\t\tItem Code:\tItem Price:\tQuantity:");
        foreach (var product in _products)
        {
            i++;
            packingLabel.AppendLine($"{i}. {product.GetProductLabel()}");
        }
        return packingLabel.ToString();
    }

    public string GetShippingLabel()
    {
        return $"{_customer.Name()}\n{_customer.Address().GetFullAddress()}";
    }
   
    public decimal GetTotalCost()
    {
        decimal totalCost = 0;

        foreach (var product in _products)
        {
            totalCost += product.GetTotal();
        }
        if (_customer.GetCountry())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return totalCost + shippingCost;
    }
}