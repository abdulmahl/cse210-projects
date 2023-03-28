using System;
using static System.Console;

class Program
{
    static void Main(string[] args)
    {
        Clear();        
        WriteLine("Order #U098Z to the United States:");
        var address1 = new Address("76 Runyon Ave", "Detroit", "Michigan", "USA");
        var customer1 = new Customer("Fidel Castro", address1);
        Product[] products1 = 
        {
            new Product("Headphones", "XC776Q", 194.95m, 1),
            new Product("USB-C Cord", "KL334P", 23.75m, 2),
            new Product("Two Pin Plug", "TN981G", 2.50m, 3)
        };
        var order1 = new Order(products1, customer1);

        Write("==================================================================");
        Write($"\nPacking Label:");
        WriteLine(order1.GetPackingLabel());
        WriteLine("Shipping Label:");
        WriteLine("Ship To,");
        WriteLine(order1.GetShippingLabel());
        WriteLine($"\t\t\t\tTotal Cost: ${order1.GetTotalCost()}");
        WriteLine("==================================================================");

        WriteLine($"\nOrder #W348X to South Africa:");
        var address2 = new Address("54 West Str", "Randburg", "Gauteng", "South Africa");
        var customer2 = new Customer("Nomsa Smuts", address2);
        Product[] products2 = 
        {
            new Product("LCD Monitor", "JV476ER", 208.35m, 1),
            new Product("Power Cord", "KLT04PE", 16.95m, 2),
            new Product("MF Cloth", "TNE357G", 1.45m, 5)
        };
        var order2 = new Order(products2, customer2);

        Write("==================================================================");
        Write($"\nPacking Label:");
        WriteLine(order2.GetPackingLabel());
        WriteLine("Shipping Label:");
        WriteLine("Ship To,");
        WriteLine(order2.GetShippingLabel());
        WriteLine($"\t\t\t\tTotal Cost: ${order2.GetTotalCost()}");
        WriteLine("==================================================================");
    }
}