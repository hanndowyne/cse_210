using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Alice Johnson", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P1001", 1200.00, 1));
        order1.AddProduct(new Product("Mouse", "P1002", 25.00, 2));

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalCost()}\n");


        Address address2 = new Address("456 King St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Michael Smith", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Headphones", "P2001", 75.00, 3));
        order2.AddProduct(new Product("Keyboard", "P2002", 60.00, 1));

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalCost()}");
    }
    
        
}