using System;

public class Activity
{
    private string activityType;
    protected int length;
    protected double distance, speed, pace;

    public Activity()
    {
    }
    public Activity(int _length)
    {
        length = _length;
    }
    public Activity(double _distance, int _length)
    {
        distance = _distance;
        length = _length;
    }
    // public Activity(int _length, float _distance, float _speed, float _pace)
    // {
    //     length = _length;
    //     distance = _distance;
    //     speed = _speed;
    //     pace = _pace;
    // }
    
    public string getDate()
    {
        return DateTime.Today.ToString("dd/MM/yyyy");
    }

    public void SetActivityType(string _activityType)
    {
        activityType = _activityType;
    }

    // getters and setters for calculations
    public void setDistance(double _distance)
    {
        distance = _distance;
    }
    public double getDistance()
    {
        return distance;
    }
    public void setSpeed(double _speed)
    {
        speed = _speed;
    }
    public double getSpeed()
    {
        return speed;
    }
    public void setPace(double _pace)
    {
        pace = _pace;
    }
    public double getPace()
    {
        return pace;
    }

    public virtual double CalculateDistance()
    {
        return distance;
    }

    public virtual double CalculateSpeed()
    {
        return speed;
    }

    public virtual double CalculatePace()
    {
        return pace;
    }

    public string Summary()
    {
        return string.Format("{0} {1} ({2} minutes) - {3} miles, {4} mph, {5} min per mile", getDate(), activityType, length, getDistance(), getSpeed(), getPace());
    }
}