namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public class IntegratedWifiModuleChipsetDecorator : ChipsetDecorator
{
    public IntegratedWifiModuleChipsetDecorator(IChipset chipset)
        : base(chipset)
    {
    }
}