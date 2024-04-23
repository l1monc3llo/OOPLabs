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

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Builders;

public interface IPersonalComputerBuilder
{
    IPersonalComputerBuilder WithComputerCase(ComputerCase computerCase);
    IPersonalComputerBuilder WithPsu(Psu psu);
    IPersonalComputerBuilder WithMotherboard(Motherboard motherboard);
    IPersonalComputerBuilder WithCpu(Cpu cpu);
    IPersonalComputerBuilder WithBios(Bios bios);
    IPersonalComputerBuilder WithRam(Ram ram);
    IPersonalComputerBuilder WithGpu(Gpu gpu);
    IPersonalComputerBuilder WithCoolingSystem(CoolingSystem coolingSystem);
    IPersonalComputerBuilder WithHdd(Hdd hdd);
    IPersonalComputerBuilder WithSsd(Ssd ssd);
    IPersonalComputerBuilder WithWifiAdapter(WifiAdapter wifiAdapter);
    IPersonalComputerBuilder WithXmpProfile(XmpProfile xmpProfile);
    IPersonalComputerBuilder Build();
}