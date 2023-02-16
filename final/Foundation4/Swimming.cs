using System;

public class Swimming : Activity
{
    private int numOfLaps;
    
    public Swimming(int _numOfLaps, int _length) : base(_length)
    {
        numOfLaps = _numOfLaps;
        SetActivityType("Swimming");
        length = _length;
    }
    public int getNumOfLaps()
    {
        return numOfLaps;
    }
    public override double CalculateDistance()
    {
        double distCalculation = getNumOfLaps() * 50.0 / 1000 * 0.62;
        base.setDistance(Math.Round(distCalculation, 2));
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