using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class WarpGamma : IWarpEngine
{
    private const double StartingFuel = 300;
    private const double ConstTravellingRange = 10000;
    public double TravelingRange => ConstTravellingRange;
    public double CalculateFuelConsumption(double distanceValue)
    {
        return StartingFuel + Math.Pow(distanceValue, 2);
    }
}