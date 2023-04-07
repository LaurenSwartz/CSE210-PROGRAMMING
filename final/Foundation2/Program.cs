using System;

class Program
{
    static void Main(string[] args)
    {
        Product product1 = new Product("Tv", 1, 3000, 1);
        Product product2 = new Product("Office Table", 1, 30, 1);
        Product product3 = new Product("Wifi Router", 3, 50, 1);
        Product product4 = new Product("Ups", 4, 200, 1);

        Address address1 = new Address("1 Hull street", "Johannesburg", "JHB", "RSA");
        Address address2 = new Address("Plot 97, 7th ave", "Johannesburg", "JHB", "RSA");

        Customer customer1 = new Customer("Lauren Swartz", address1);
        Customer customer2 = new Customer("Maxine Marais", address2);

        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);

        DisplayOrderDetails(order1);
        System.Console.WriteLine("\n------------------\n");
        DisplayOrderDetails(order2);
    }

    static void DisplayOrderDetails(Order order)
    {
        System.Console.WriteLine(order.GetPackingLabel());
        System.Console.WriteLine(order.GetShippingLabel());
        System.Console.WriteLine($"Total Price: ${order.CalculateTotalCost():0.00}");
    }
}