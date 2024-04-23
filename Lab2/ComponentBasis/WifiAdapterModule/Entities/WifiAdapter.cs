using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Entities;

public class WifiAdapter : IWifiAdapter
{
    public WifiAdapter(
        WifiStandardVersionVariety wifiStandardVersion,
        PcieVersionVariety pcieVersion,
        double powerConsumptionInW)
    {
        WifiStandardVersion = wifiStandardVersion;
        PcieVersion = pcieVersion;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public WifiStandardVersionVariety WifiStandardVersion { get; }
    public PcieVersionVariety PcieVersion { get; }
    public double PowerConsumptionInW { get; }
}