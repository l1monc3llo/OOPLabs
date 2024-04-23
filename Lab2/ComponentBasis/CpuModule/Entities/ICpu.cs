using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;

public interface ICpu
{
    CpuVariety CpuModel { get; }
    double CoreFrequencyInGHz { get; }
    CoresNumberStandard CoresNumber { get; }
    SocketType Socket { get; }
    IReadOnlyCollection<double> SupportedMemoryFrequencies { get; }
    int Tdp { get; }
    double PowerConsumptionInW { get; }
}