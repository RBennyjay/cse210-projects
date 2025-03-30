using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating addresses
        Address address1 = new Address("251 N Broad Street", "Middletown", "DE", "USA");
        Address address2 = new Address("160 Bedford Rd", "Toronto", "ON", "Canada");

        // Creating customers
        Customer customer1 = new Customer("Ebenezer John", address1);
        Customer customer2 = new Customer("Jane Thompson", address2);

        // Creating orders
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "A123", 650, 1));
        order1.AddProduct(new Product("Iphone", "B456", 25, 2));

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Ipad", "C789", 300, 1));
        order2.AddProduct(new Product("Mouse", "D012", 50, 1));
        order2.AddProduct(new Product("Headphones", "E345", 75, 1));

        // Display results
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}\n");

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}