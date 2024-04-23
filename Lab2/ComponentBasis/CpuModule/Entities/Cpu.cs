using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;

public class Cpu : ICpu
{
    private readonly List<double> _supportedMemoryFrequencies;

    public Cpu(
        CpuVariety cpuModel,
        double coreFrequencyInGHz,
        CoresNumberStandard coresNumber,
        SocketType socket,
        IEnumerable<double> supportedMemoryFrequencies,
        int tdp,
        double powerConsumptionInW)
    {
        CpuModel = cpuModel;
        CoreFrequencyInGHz = coreFrequencyInGHz;
        CoresNumber = coresNumber;
        Socket = socket;
        _supportedMemoryFrequencies = supportedMemoryFrequencies.ToList();
        Tdp = tdp;
        PowerConsumptionInW = powerConsumptionInW;
    }

    public CpuVariety CpuModel { get; }
    public double CoreFrequencyInGHz { get; }
    public CoresNumberStandard CoresNumber { get; }
    public SocketType Socket { get; }
    public IReadOnlyCollection<double> SupportedMemoryFrequencies => _supportedMemoryFrequencies;
    public int Tdp { get; }
    public double PowerConsumptionInW { get; }
}
