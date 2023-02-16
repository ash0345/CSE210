using System;

public class Cycling : Activity
{
    public Cycling(double _distance, int _length) : base(_distance, _length)
    {
        length = _length;
        distance = _distance;
        SetActivityType("Cycling");
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