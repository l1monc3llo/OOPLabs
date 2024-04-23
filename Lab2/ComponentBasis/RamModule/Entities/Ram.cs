using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.XmpProfileModule.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Entities;

public class Ram
{
    private readonly List<JedecFrequencyAndVoltageStandard> _supportedJedecFrequenciesAndVoltage;
    private readonly List<XmpProfile> _availableXmpProfiles;
    public Ram(
        RamSizeInGbStandard sizeInGb,
        IEnumerable<JedecFrequencyAndVoltageStandard> supportedJedecFrequenciesAndVoltage,
        IEnumerable<XmpProfile> availableXmpProfiles,
        DdrVersion ddr,
        double powerConsumptionInW)
    {
        SizeInGb = sizeInGb;
        _supportedJedecFrequenciesAndVoltage = supportedJedecFrequenciesAndVoltage.ToList();
        _availableXmpProfiles = availableXmpProfiles.ToList();
        Ddr = ddr;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public RamSizeInGbStandard SizeInGb { get; }

    public IReadOnlyCollection<JedecFrequencyAndVoltageStandard> SupportedJedecFrequenciesAndVoltage => _supportedJedecFrequenciesAndVoltage;
    public IReadOnlyCollection<XmpProfile> AvailableXmpProfiles => _availableXmpProfiles;
    public DdrVersion Ddr { get; }
    public double PowerConsumptionInW { get; }
}