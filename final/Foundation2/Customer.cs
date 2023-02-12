using System;

public class Customer 
{
    private string name;
    private Address address = new Address();

    private bool livesUSA;

    public Customer()
    {
    }
    public Customer(string _name)
    {
        name = _name;
    }

    public string getCustomerName()
    {
        return name;
    }

    public void getLocal()
    {
        livesUSA = address.returnLocal();
    }
}