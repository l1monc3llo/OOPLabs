namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class PulseClassC : IPulseEngine
{
    private const double ConstSpeed = 10.5;
    private const double StartingFuel = 50;
    public double CalculateSpeed(double time)
    {
        return ConstSpeed;
    }

    public double CalculateFuelConsumption(double distanceValue)
    {
        return StartingFuel + distanceValue;
    }
}