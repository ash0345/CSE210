using System;

public class Lecture : Event
{
    private string eventType = "Lectures";
    private string speakerName;
    private int capacity;
    public Lecture(string _eventTitle, string _description, string _date, string _time, /*EventAddress _address,*/ string _speakerName, int _capacity): base(_eventTitle, _description, _date, _time/*, _address*/)
    {
        this.speakerName = _speakerName;
        this.capacity = _capacity;
    }

    public override string FullDetails()
    {

        IList<string> strList = new List<string>();
        strList.Add("Event Type: "+this.eventType);
        strList.Add(this.StandardDetails());

        strList.Add("Speaker Name: "+this.speakerName);
        strList.Add("Capacity: "+this.capacity);
       

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