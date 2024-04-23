namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Entities;

public class IntegratedBluetoothModuleWifiAdapterDecorator : WifiAdapterDecorator
{
    public IntegratedBluetoothModuleWifiAdapterDecorator(IWifiAdapter wifiAdapter)
        : base(wifiAdapter)
    {
    }
}