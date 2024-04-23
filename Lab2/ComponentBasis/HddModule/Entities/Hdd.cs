using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.HddModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.HddModule.Entities;

public class Hdd
{
    public Hdd(
        HddSizeInGbStandard capacityInGb,
        double spindleSpeedInRadPerSecond,
        double powerConsumptionInW)
    {
        Capacity = capacityInGb;
        SpindleSpeedInRadPerSecond = spindleSpeedInRadPerSecond;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public HddSizeInGbStandard Capacity { get; }
    public double SpindleSpeedInRadPerSecond { get; }
    public double PowerConsumptionInW { get; }
}