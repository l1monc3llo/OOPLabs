namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class WarpAlpha : IWarpEngine
{
    private const double StartingFuel = 200;
    private const double ConstTravellingRange = 5000;
    public double TravelingRange => ConstTravellingRange;
    public double CalculateFuelConsumption(double distanceValue)
    {
        return StartingFuel + distanceValue;
    }
}