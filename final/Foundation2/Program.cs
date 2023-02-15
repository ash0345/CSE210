using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Your Orders:");

        // create at least two orders with a 2-3 products each
        Order order1 = new Order();
        Console.WriteLine("Order 1");
        Console.WriteLine();

        Customer customer1 = new Customer("Ashley Anglesey");
        order1.setCustomer(customer1);
        Address address1 = new Address("123 apple street", "keaau", "HI", "USA");
        customer1.setCustomerAddress(address1);
        // address1.setCountry("USA");
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
        order1.displayPackingLabel();

        // Shipping Label:
        order1.displayShippingLabel();

        // Total Price:
        order1.getShippingCost();
        order1.calculateCost();
        Console.WriteLine(order1.displayCost());

        Console.WriteLine("_______________________________________________");
        Console.WriteLine();

        Order order2 = new Order();
        Console.WriteLine("Order 2");
        Console.WriteLine();

        Customer customer2 = new Customer("Eli Weichers");
        order2.setCustomer(customer2);
        Address address2 = new Address("3483 Happy St.", "Smallville", "England", "Europe");
        customer2.setCustomerAddress(address2);
        // address1.setCountry("USA");
        Product product3 = new Product("logo t-shirt", 1280, 17.50, 3);
        Product product4 = new Product("peanut butter", 4511, 9.50, 4);
        Product product5 = new Product("ginger beer", 0325, 7, 1);
        order2.productsList.Add(product3);
        order2.productsList.Add(product4);
        order2.productsList.Add(product5);

        // append item prices to the price list
        double product3Price = product3.calculatePrice();
        order2.productsPriceList.Add(product3Price);
        double product4Price = product4.calculatePrice();
        order2.productsPriceList.Add(product4Price);
        double product5Price = product5.calculatePrice();
        order2.productsPriceList.Add(product5Price);

        // Packing Label:
        order2.displayPackingLabel();

        // Shipping Label:
        order2.displayShippingLabel();

        // Total Price:
        order2.getShippingCost();
        order2.calculateCost();
        Console.WriteLine(order2.displayCost());
    }
}