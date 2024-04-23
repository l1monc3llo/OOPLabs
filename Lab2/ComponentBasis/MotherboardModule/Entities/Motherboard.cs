using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Entities;

public class Motherboard
{
    public Motherboard(
        SocketType cpuSocket,
        int pcieLanesCount,
        int sataPortsCount,
        IChipset chipset,
        DdrVersion ddrStandard,
        RamSlotsNumberStandard ramSlotsNumber,
        MotherboardFormFactor formFactor)
    {
        CpuSocket = cpuSocket;
        PcieLanesCount = pcieLanesCount;
        SataPortsCount = sataPortsCount;
        Chipset = chipset;
        DdrStandard = ddrStandard;
        RamSlotsNumber = ramSlotsNumber;
        FormFactor = formFactor;
    }

    public SocketType CpuSocket { get; }
    public int PcieLanesCount { get; }
    public int SataPortsCount { get; }
    public IChipset Chipset { get; }
    public DdrVersion DdrStandard { get; }
    public RamSlotsNumberStandard RamSlotsNumber { get; }
    public MotherboardFormFactor FormFactor { get; }
}