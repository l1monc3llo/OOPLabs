using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class WarpOmega : IWarpEngine
{
    private const double StartingFuel = 350;
    private const double ConstTravellingRange = 7500;
    public double TravelingRange => ConstTravellingRange;
    public double CalculateFuelConsumption(double distanceValue)
    {
        return StartingFuel + (distanceValue * Math.Log(distanceValue));
    }
}