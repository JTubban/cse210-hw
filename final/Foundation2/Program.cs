using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        Order order1 = new Order("John Reyes", "Bulagao", "Tuao", "Cagayan Valley", "Philippines", false);
        order1.AddOrder("Laptop", "001", 3000, 2);
        order1.AddOrder("Head phone", "002", 60, 1);
        order1.AddOrder("Xbox", "003", 500, 2);
        order1.DisplayShippingLabel();

        Order order2 = new Order("Teddy Myers", "Waipahu", "Oahu", "Hawaii", "USA", true);
        order2.AddOrder("Milk", "001", 4.10, 2);
        order2.AddOrder("Cheese", "002", 2.30, 1);
        order2.AddOrder("Honey", "003", 3.10, 1);
        order2.DisplayShippingLabel();
    }
}