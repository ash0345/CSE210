using System;

public class Order
{
    private double orderCost = 0;
    private double shippingCost;
    public List<Product> productsList = new List<Product>();
    public List<double> productsPriceList = new List<double>();
    Customer customer;
    private Address address = new Address();
    private string shippingLabel;

    public Order()
    {
    }

    // public set customer
    public void setCustomer(Customer _customer)
    {
        customer = _customer;
    }

    // setter
    public void setShippingLabel(string _shippingLabel)
    {
        shippingLabel = _shippingLabel;
    }
    public void displayShippingLabel()
    {
        // name and address
        shippingLabel = string.Format("\nShip to:\n{0}\n{1}", customer.getCustomerName(), customer.getCustomerAddress());
        Console.WriteLine(shippingLabel);
    }

    public void displayPackingLabel()
    {
        // name and product id for each item in the list (foreach)
        foreach (Product product in productsList)
        {
            Console.WriteLine(product.formatProduct());
        }
    }

    public void getShippingCost()
    {
        bool local = customer.getLocal(); //address.returnLocal(); //customer.getLocal

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
        return string.Format("\nTotal Cost: ${0}", orderCost);
    }
}