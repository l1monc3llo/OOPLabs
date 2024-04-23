using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Entities;

public class WifiAdapterDecorator : IWifiAdapter
{
    private IWifiAdapter _wifiAdapter;

    public WifiAdapterDecorator(IWifiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
    }

    public WifiStandardVersionVariety WifiStandardVersion => _wifiAdapter.WifiStandardVersion;
    public PcieVersionVariety PcieVersion { get; }
    public double PowerConsumptionInW { get; }
}