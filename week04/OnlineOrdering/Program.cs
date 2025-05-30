using System;

class Program
{
    static void Main(string[] args)
    {
        // First order - USA customer
        Address addr1 = new Address("123 Maple Street", "Springfield", "IL", "USA");
        Customer cust1 = new Customer("John Doe", addr1);
        Order order1 = new Order(cust1);
        order1.AddProduct(new Product("Notebook", "P001", 3.5, 2));
        order1.AddProduct(new Product("Pen", "P002", 1.25, 5));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}\n");

        // Second order - International customer
        Address addr2 = new Address("456 King Road", "Toronto", "ON", "Canada");
        Customer cust2 = new Customer("Alice Smith", addr2);
        Order order2 = new Order(cust2);
        order2.AddProduct(new Product("Sketchbook", "P003", 8.99, 1));
        order2.AddProduct(new Product("Colored Pencils", "P004", 5.49, 2));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");
    }
}