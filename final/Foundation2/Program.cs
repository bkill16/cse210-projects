using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();

        Address customer1Address = new Address("20 Ingram Street", "Queens", "New York", "USA");
        
        Customer customer1 = new Customer("Peter Parker", customer1Address);

        Product c1Product1 = new Product("Red Spandex", "AB001", 10.95, 3);
        Product c1Product2 = new Product("Lego Venator-Class Republic Attack Cruiser", "LG024", 649.99, 1);
        Product c1Product3 = new Product("Oscorp Spider Silk", "OS096", 23.99, 5);

        Order order1 = new Order(customer1);
        order1.AddProduct(c1Product1);
        order1.AddProduct(c1Product2);
        order1.AddProduct(c1Product3);

        order1.ComputeShippingCost();
        order1.ComputeTotalPrice();

        order1.GeneratePackingLabel();
        order1.DisplayTotal();
        order1.GenerateShippingLabel();

        Console.WriteLine();

        Address customer2Address = new Address("344 Clinton Street", "Midtown", "Metropolis", "Afghanistan");

        Customer customer2 = new Customer("Clark Kent", customer2Address);

        Product c2Product1 = new Product("Red Underpants", "UP865", 8.99, 5);
        Product c2Product2 = new Product("Fake Glasses", "GL088", 15.85, 100);
        Product c2Product3 = new Product("Button Down Shirts", "BD784", 27.99, 50);

        Order order2 = new Order(customer2);
        order2.AddProduct(c2Product1);
        order2.AddProduct(c2Product2);
        order2.AddProduct(c2Product3);

        order2.ComputeShippingCost();
        order2.ComputeTotalPrice();

        order2.GeneratePackingLabel();
        order2.DisplayTotal();
        order2.GenerateShippingLabel();

        Console.WriteLine();


    }
}