using System;

public class Address
{
    private string streetAddress;
    private string city;
    private string state;
    private string country;

    public Address()
    {
    }
    public Address(string _street, string _city, string _state, string _country)
    {
        streetAddress = _street;
        city = _city;
        state = _state;
        country = _country;
    }

    public bool returnLocal()
    {
        if (country == "USA")
        {
            return true;
        } else
        {
            return false;
        }
    }

    public string toString()
    {
        return string.Format("{0}\n{1} {2} {3}", streetAddress, city, state, country);
    }
}