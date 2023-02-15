using System;

public class Outdoor : Event
{
    private string eventType = "Outdoor";
    private string weather;
    public Outdoor(string _eventTitle, string _description, string _date, string _time/*, EventAddress _address*/, string _weather): base(_eventTitle, _description, _date, _time/*, _address*/)
    {
        this.weather = _weather;
    }

    public override string FullDetails()
    {

        IList<string> strList = new List<string>();
        strList.Add("Event Type: "+this.eventType);
        strList.Add(this.StandardDetails());

        strList.Add("Weather: "+this.weather);

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