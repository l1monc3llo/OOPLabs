using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.SsdModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.SsdModule.Entities;

public class Ssd
{
    private readonly List<SsdConnectionOption> _connectionOptions;
    public Ssd(
        IEnumerable<SsdConnectionOption> connectionOptions,
        SsdSizeInGbStandard capacityInGb,
        double maximumOperatingSpeedInMbPerSecond,
        double powerConsumptionInW)
    {
        _connectionOptions = connectionOptions.ToList();
        Capacity = capacityInGb;
        MaximumOperatingSpeedInMbPerSecond = maximumOperatingSpeedInMbPerSecond;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public IReadOnlyCollection<SsdConnectionOption> ConnectionOptions => _connectionOptions;
    public SsdSizeInGbStandard Capacity { get; }
    public double MaximumOperatingSpeedInMbPerSecond { get; }
    public double PowerConsumptionInW { get; }
}