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

    // set address
    public void setCustomerAddress(Address _address)
    {
        address = _address;
    }

    public string getCustomerName()
    {
        return name;
    }

    public bool getLocal()
    {
        livesUSA = address.returnLocal();
        return livesUSA;
    }

    // get customer address get address.tostring
    public string getCustomerAddress()
    {
        return address.toString();
    }

}