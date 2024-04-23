namespace Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;

public interface IPulseEngine
{
    double CalculateSpeed(double time);
    double CalculateFuelConsumption(double distanceValue);
}