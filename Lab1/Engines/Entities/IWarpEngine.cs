namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public interface IWarpEngine
{
    double TravelingRange { get; }
    double CalculateFuelConsumption(double distanceValue);
}