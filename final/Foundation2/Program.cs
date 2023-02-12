using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your Orders:");

        // create at least two orders with a 2-3 products each
        Order order1 = new Order();
        Customer customer1 = new Customer("Ashley Anglesey");
        Address address1 = new Address("123 apple street", "keaau", "HI", "USA");
        Product product1 = new Product("icecream", 1011, 10, 2);
        Product product2 = new Product("bananas", 1011, 5, 3);
        order1.productsList.Add(product1);
        order1.productsList.Add(product2);

        // append item prices to the price list
        double product1Price = product1.calculatePrice();
        order1.productsPriceList.Add(product1Price);
        double product2Price = product2.calculatePrice();
        order1.productsPriceList.Add(product2Price);

        // Packing Label:
        // Console.WriteLine(order1.displayPackingLabel());

        // // Shipping Label:
        // Console.WriteLine(order1.displayShippingLabel());

        // Total Price:
        order1.getShippingCost();
        order1.calculateCost();
        Console.WriteLine(order1.displayCost());
    }
}