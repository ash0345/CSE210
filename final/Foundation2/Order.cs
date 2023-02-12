using System;

public class Order
{
    private double orderCost = 0;
    private double shippingCost;
    public List<Product> productsList = new List<Product>();
    public List<double> productsPriceList = new List<double>();
    private Customer customer = new Customer();
    private Address address = new Address();

    public Order()
    {
    }

    // public string displayShippingLabel()
    // {
    //     // name and address
    //     return string.Format("Ship to:\n{0}\n{1}}", customer.getCustomerName(), address.toString());
    // }

    // public void displayPackingLabel()
    // {
    //     // name and product id for each item in the list (foreach)
    //     foreach (Product product in productsList)
    //     {
    //         return string.Format("•{0}", product);
    //     }
    // }

    public void getShippingCost()
    {
        bool local = address.returnLocal(); //not working check where local is wrong

        if (local == true)
        {
            shippingCost = 5;
        } else
        {
            shippingCost = 35;
        }
    }

    public double calculateCost()
    {
        foreach (double price in productsPriceList)
        {
            orderCost += price;
        }
        orderCost += shippingCost;
        return orderCost;
    }
    public string displayCost()
    {
        return string.Format("Total Cost: ${0}", orderCost);
    }
}