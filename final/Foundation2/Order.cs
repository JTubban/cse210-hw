public class Order: Customer
{
    Product product = new Product();

    public Order(string customerName, string streetAddress, string city, string stateProvince, string country, bool isInUsa)
    {
        _customerName = customerName;
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _isInUsa = isInUsa;
    }
    public void AddOrder(string productName, string productId, double price, int quantity)
    {
        product.GetList().Add($"{productName},{productId},{price},{quantity}");
    }

    private void Orders()
    {   
        double totalPrice = 0.0;

        foreach (string order in product.GetList())
        {
            string[] parts = order.Split(',');
            string productName = parts[0];
            double price = double.Parse(parts[2]);
            int quantity = int.Parse(parts[3]);

            Console.WriteLine($"{productName}({quantity}) - ${price.ToString("f")}");

            totalPrice += price * quantity;
        }

        if (_isInUsa)
        {
            totalPrice += 5;
            Console.WriteLine("Shipping cost inside USA: $5");
        }
        else
        {
            totalPrice += 35;
            Console.WriteLine("Shipping cost outside USA: $35");
        }
        Console.WriteLine();
        Console.WriteLine($"TOTAL PRICE: ${totalPrice.ToString("F2")}");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine();
        Console.WriteLine("SHIPPING LABEL");
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine("From: FastShip Logistics");
        Console.WriteLine("Address: Inc.123 Shipping Lane, Suite 456, Cityville, ST 79898, USA");
        Console.WriteLine();
        Console.WriteLine($"To: {_customerName}");
        Console.WriteLine($"Address: {_streetAddress}, {_city}, {_stateProvince}, {_country}");
        Console.WriteLine();
        Console.WriteLine("ORDER(S):");
        Orders();
        Console.WriteLine("---------------------------------------------------------------------");
        Console.WriteLine();
    }
}