using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.BiosModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.ComputerCaseModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CoolingSystemModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.GpuModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.HddModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.PsuModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.SsdModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.WifiAdapterModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.XmpProfileModule.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Entities;

public class Pc
{
    public Pc(
        ComputerCase? computerCase,
        Psu? psu,
        Motherboard? motherboard,
        ICpu? cpu,
        Bios? bios,
        Ram? ram,
        Gpu? gpu,
        CoolingSystem? coolingSystem,
        Hdd? hdd,
        Ssd? ssd,
        WifiAdapter? wifiAdapter,
        XmpProfile? xmpProfile)
    {
        ComputerCase = computerCase;
        Psu = psu;
        Motherboard = motherboard;
        Cpu = cpu;
        Bios = bios;
        Ram = ram;
        Gpu = gpu;
        CoolingSystem = coolingSystem;
        Hdd = hdd;
        Ssd = ssd;
        WifiAdapter = wifiAdapter;
        XmpProfile = xmpProfile;
    }

    public ComputerCase? ComputerCase { get; private set; }
    public Psu? Psu { get; private set; }
    public Motherboard? Motherboard { get; private set; }
    public ICpu? Cpu { get; private set; }
    public Bios? Bios { get; }
    public Ram? Ram { get; }
    public Gpu? Gpu { get; }
    public CoolingSystem? CoolingSystem { get; }
    public Hdd? Hdd { get; }
    public Ssd? Ssd { get; }
    public WifiAdapter? WifiAdapter { get; }
    public XmpProfile? XmpProfile { get; }

    public double CalculateSystemLoad()
    {
        double summarySystemLoad = (Cpu?.PowerConsumptionInW ?? 0) + (Gpu?.PowerConsumptionInW ?? 0) +
                                   (Hdd?.PowerConsumptionInW ?? 0) + (Ssd?.PowerConsumptionInW ?? 0) +
                                   (WifiAdapter?.PowerConsumptionInW ?? 0) + (Ram?.PowerConsumptionInW ?? 0);
        return summarySystemLoad;
    }
}