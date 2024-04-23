using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.GpuModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.GpuModule.Entities;

public class Gpu
{
    public Gpu(
        double heightInInches,
        double widthInInches,
        VideoMemoryInGbStandard videoMemoryInGb,
        PcieVersionVariety pcieVersion,
        double chipFrequencyInMhz,
        double powerConsumptionInW)
    {
        HeightInInches = heightInInches;
        WidthInInches = widthInInches;
        VideoMemoryInGb = videoMemoryInGb;
        PcieVersion = pcieVersion;
        ChipFrequencyInMhz = chipFrequencyInMhz;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public double HeightInInches { get; }
    public double WidthInInches { get; }
    public VideoMemoryInGbStandard VideoMemoryInGb { get; }
    public PcieVersionVariety PcieVersion { get; }
    public double ChipFrequencyInMhz { get; }
    public double PowerConsumptionInW { get; }
}