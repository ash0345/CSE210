using System;

public class Product 
{
    private string productName;
    private int productId;
    private double itemPrice;
    private double price = 0;
    private int quantity;

    public Product(string _name, int _id, double _price, int _quantity)
    {
        productName = _name;
        productId = _id;
        itemPrice = _price;
        quantity = _quantity;
    }

    public double calculatePrice()
    {
        // price * quantity
        price = itemPrice * quantity;
        return price;
    }
}