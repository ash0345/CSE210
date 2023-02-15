using System;

public class EventAddress
{
    private string address1;
    private string city;
    private string state;
    private string zipCode;

    public EventAddress()
    {
    }
    public EventAddress(string _address1, string _city, string _state, string _zipCode)
    {
        this.address1 = _address1;
        this.city = _city;
        this.state = _state;
        this.zipCode = _zipCode;
    }

    public override string ToString()
    {
        return string.Format("{0}, {1}, {2} {3}", this.address1, this.city, this.state, this.zipCode);
    }
}

