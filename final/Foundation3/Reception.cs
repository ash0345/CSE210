using System;

public class Reception : Event
{
    private string eventType = "Reception";
    private string email;
    public Reception(string _eventTitle, string _description, string _date, string _time/*, EventAddress _address*/, string _email): base(_eventTitle, _description, _date, _time/*, _address*/)
    {
        this.email = _email;
    }

    public override string FullDetails()
    {

        IList<string> strList = new List<string>();
        strList.Add("Event Type: "+this.eventType);
        strList.Add(this.StandardDetails());

        strList.Add("RSVP Email: "+this.email);

        return string.Join("\n", strList.ToArray());

    }

    public override string ShortDescription()
    {
        IList<string> strList = new List<string>();
        strList.Add("Event Type: "+this.eventType);
        strList.Add("Title: "+this.EventTitle);
        strList.Add("Date: "+this.EventDate);

        return string.Join("\n", strList.ToArray());
    }
}