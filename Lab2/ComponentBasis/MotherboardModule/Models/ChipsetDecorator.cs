using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public class ChipsetDecorator : IChipset
{
    private readonly IChipset _chipset;

    public ChipsetDecorator(IChipset chipset)
    {
        _chipset = chipset;
    }

    public IReadOnlyCollection<double> SupportedMemoryFrequenciesInMhz => _chipset.SupportedMemoryFrequenciesInMhz;
}