namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public class XmlSupportChipsetDecorator : ChipsetDecorator
{
    public XmlSupportChipsetDecorator(IChipset chipset)
        : base(chipset)
    {
    }
}