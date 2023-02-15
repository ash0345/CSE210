using System;

public abstract class Event
{
    private string eventTitle, description, date, time;

    public string EventTitle{
        get{
            return this.eventTitle;
        }
    }
    public string EventDate{
        get{
            return this.date;
        }
    }

    private EventAddress address;

    public Event(string _eventTitle, string _description, string _date, string _time/*, EventAddress _address*/)
    {
        this.eventTitle = _eventTitle;
        this.description = _description;
        this.time = _time;
        this.date = _date;
        // this.address  = _address;
    }

    public EventAddress getAddress()
    {
        return address;
    }

    public void setAddress(EventAddress _address)
    {
        address = _address;
    }

    public string StandardDetails()
    {
        IList<string> strList = new List<string>();

        strList.Add("Title: "+this.eventTitle);
        strList.Add("Description: "+this.description);
        strList.Add("Date: "+this.date);
        strList.Add("Time: "+this.time);
        strList.Add("Address: "+this.address);

        return string.Join("\n", strList.ToArray());
    }

    public abstract string FullDetails();
    //{
        // IList<string> strList = new List<string>();

        // strList.Add("Title: "+this.eventTitle);
        // strList.Add("Description: "+this.description);
        // strList.Add("Date: "+this.date);
        // strList.Add("Time: "+this.time);

        // return string.Join("\n", strList.ToArray());
    //}

    public abstract string ShortDescription();
    // {
    //     IList<string> strList = new List<string>();

    //     strList.Add("Title: "+this.eventTitle);
        

    //     return string.Join("\n", strList.ToArray());
    // }
    
}