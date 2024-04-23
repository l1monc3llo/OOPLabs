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

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Updaters;

public interface IPersonalComputerUpdater
{
    IPersonalComputerUpdater UpdateComputerCase(ComputerCase computerCase);
    IPersonalComputerUpdater UpdatePsu(Psu psu);
    IPersonalComputerUpdater UpdateMotherboard(Motherboard motherboard);
    IPersonalComputerUpdater UpdateCpu(ICpu cpu);
    IPersonalComputerUpdater UpdateBios(Bios bios);
    IPersonalComputerUpdater UpdateRam(Ram ram);
    IPersonalComputerUpdater UpdateGpu(Gpu gpu);
    IPersonalComputerUpdater UpdateCoolingSystem(CoolingSystem coolingSystem);
    IPersonalComputerUpdater UpdateHdd(Hdd hdd);
    IPersonalComputerUpdater UpdateSsd(Ssd ssd);
    IPersonalComputerUpdater UpdateWifiAdapter(WifiAdapter wifiAdapter);
    IPersonalComputerUpdater UpdateXmpProfile(XmpProfile xmpProfile);
}