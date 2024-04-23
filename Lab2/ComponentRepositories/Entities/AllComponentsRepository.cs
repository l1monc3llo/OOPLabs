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

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentRepositories.Entities;

public class AllComponentsRepository
{
    public ComponentRepository<ComputerCase> ComputerCaseStorage { get; } = new ComponentRepository<ComputerCase>();
    public ComponentRepository<Psu> PsuStorage { get; } = new ComponentRepository<Psu>();
    public ComponentRepository<Motherboard> MotherboardStorage { get; } = new ComponentRepository<Motherboard>();
    public ComponentRepository<ICpu> CpuStorage { get; } = new ComponentRepository<ICpu>();
    public ComponentRepository<Bios> BiosStorage { get; } = new ComponentRepository<Bios>();
    public ComponentRepository<Ram> RamStorage { get; } = new ComponentRepository<Ram>();
    public ComponentRepository<Gpu> GpuStorage { get; } = new ComponentRepository<Gpu>();
    public ComponentRepository<CoolingSystem> CoolingSystemStorage { get; } = new ComponentRepository<CoolingSystem>();
    public ComponentRepository<Hdd> HddStorage { get; } = new ComponentRepository<Hdd>();
    public ComponentRepository<Ssd> SsdStorage { get; } = new ComponentRepository<Ssd>();
    public ComponentRepository<WifiAdapter> WifiAdapterStorage { get; } = new ComponentRepository<WifiAdapter>();
    public ComponentRepository<XmpProfile> XmpProfileStorage { get; } = new ComponentRepository<XmpProfile>();
}