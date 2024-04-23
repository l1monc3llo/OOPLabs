using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;

public class CpuDecorator : ICpu
{
    private readonly ICpu _cpu;

    public CpuDecorator(ICpu cpu)
    {
        _cpu = cpu;
    }

    public CpuVariety CpuModel => _cpu.CpuModel;
    public double CoreFrequencyInGHz => _cpu.CoreFrequencyInGHz;
    public CoresNumberStandard CoresNumber => _cpu.CoresNumber;
    public SocketType Socket => _cpu.Socket;
    public IReadOnlyCollection<double> SupportedMemoryFrequencies => _cpu.SupportedMemoryFrequencies;
    public int Tdp => _cpu.Tdp;
    public double PowerConsumptionInW => _cpu.PowerConsumptionInW;
}