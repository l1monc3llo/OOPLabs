using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.ComputerCaseModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.ComputerCaseModule.Entities;

public class ComputerCase
{
    private readonly List<MotherboardFormFactor> _supportedMotherboardFormFactors;

    public ComputerCase(
        double maxGpuHeightInInches,
        double maxGpuWidthInInches,
        IEnumerable<MotherboardFormFactor> supportedMotherboardFormFactors,
        ComputerCaseDimensions dimensions)
    {
        MaxGpuHeightInInches = maxGpuHeightInInches;
        MaxGpuWidthInInches = maxGpuWidthInInches;
        _supportedMotherboardFormFactors = supportedMotherboardFormFactors.ToList();
        Dimensions = dimensions;
    }

    public double MaxGpuHeightInInches { get; }
    public double MaxGpuWidthInInches { get; }
    public IReadOnlyCollection<MotherboardFormFactor> SupportedMotherboardFormFactors => _supportedMotherboardFormFactors;
    public ComputerCaseDimensions Dimensions { get; }
}