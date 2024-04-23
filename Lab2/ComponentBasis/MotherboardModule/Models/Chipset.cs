using System.Collections.Generic;
using System.Linq;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public class Chipset : IChipset
{
    private readonly List<double> _supportedMemoryFrequenciesInMhz;

    public Chipset(IEnumerable<double> supportedFrequenciesInMhz)
    {
        _supportedMemoryFrequenciesInMhz = supportedFrequenciesInMhz.ToList();
    }

    public IReadOnlyCollection<double> SupportedMemoryFrequenciesInMhz => _supportedMemoryFrequenciesInMhz;
}