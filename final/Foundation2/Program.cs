using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("853 N 1st St", "Boise", "ID", "83702", "USA");
        Customer customer1 = new Customer("Chris Shale", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Talaria", "MTSX60", 10.99, 2));
        order1.AddProduct(new Product("Tilapia", "FISHX60", 18.23, 4));

        Address address2 = new Address("759 Green St", "Melbourne", "VIC", "10001", "Australia");
        Customer customer2 = new Customer("Terrance Rain", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Flying Fish", "FISHX61", 22.50, 3));
        order2.AddProduct(new Product("Boomerang", "EB1", 15.75, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}");

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}");
    }
}
