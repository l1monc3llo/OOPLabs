using System.Collections.Generic;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public interface IChipset
{
    IReadOnlyCollection<double> SupportedMemoryFrequenciesInMhz { get; }
}