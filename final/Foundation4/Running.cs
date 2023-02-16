using System;

public class Running : Activity
{
    private int numOfLaps;
    
    public Running(int _numOfLaps, int _length) : base(_length)
    {
        numOfLaps = _numOfLaps;
        SetActivityType("Running");
        length = _length;
    }
    public int getNumOfLaps()
    {
        return numOfLaps;
    }
    public override double CalculateDistance()
    {
        base.setDistance(getNumOfLaps() * 200 / 1000 * 0.62);
        return base.CalculateDistance();
    }
    public override double CalculateSpeed()
    {
        double speedCalculation = (distance / length) * 60;
        base.setSpeed(Math.Round(speedCalculation, 2));
        return base.CalculateSpeed();
    }
    public override double CalculatePace()
    {
        double paceCalculation = length / distance;
        base.setPace(Math.Round(paceCalculation, 2));
        return base.CalculatePace();
    }
}