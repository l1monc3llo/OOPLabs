using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Entities;

public interface IWifiAdapter
{
    WifiStandardVersionVariety WifiStandardVersion { get; }
    PcieVersionVariety PcieVersion { get; }
    double PowerConsumptionInW { get; }
}