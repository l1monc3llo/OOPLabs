using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public class PulseClassE : IPulseEngine
{
    private const double StartingFuel = 80;
    public double CalculateSpeed(double time)
    {
        return Math.Pow(Math.E, time) * Math.Pow(time, 2) / 2;
    }

    public double CalculateFuelConsumption(double distanceValue)
    {
        return StartingFuel + Math.Pow(distanceValue, Math.E);
    }
}