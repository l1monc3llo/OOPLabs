using System;
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
using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Services;

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Updaters;
public class PersonalComputerUpdater : IPersonalComputerUpdater
{
    private ComputerCase? _computerCase;
    private Psu? _psu;
    private Motherboard? _motherboard;
    private ICpu? _cpu;
    private Bios? _bios;
    private Ram? _ram;
    private Gpu? _gpu;
    private CoolingSystem? _coolingSystem;
    private Hdd? _hdd;
    private Ssd? _ssd;
    private WifiAdapter? _wifiAdapter;
    private XmpProfile? _xmpProfile;
    private Pc _pc;

    public PersonalComputerUpdater(Pc pc)
    {
        if (pc is null)
        {
            throw new ArgumentNullException(nameof(pc));
        }

        _pc = pc;
        _computerCase = pc.ComputerCase;
        _psu = pc.Psu;
        _motherboard = pc.Motherboard;
        _cpu = pc.Cpu;
        _bios = pc.Bios;
        _ram = pc.Ram;
        _gpu = pc.Gpu;
        _coolingSystem = pc.CoolingSystem;
        _hdd = pc.Hdd;
        _ssd = pc.Ssd;
        _wifiAdapter = pc.WifiAdapter;
        _xmpProfile = pc.XmpProfile;
    }

    public IPersonalComputerUpdater UpdateComputerCase(ComputerCase computerCase)
    {
        _computerCase = computerCase;
        return this;
    }

    public IPersonalComputerUpdater UpdatePsu(Psu psu)
    {
        _psu = psu;
        return this;
    }

    public IPersonalComputerUpdater UpdateMotherboard(Motherboard motherboard)
    {
        _motherboard = motherboard;
        return this;
    }

    public IPersonalComputerUpdater UpdateCpu(ICpu cpu)
    {
        _cpu = cpu;
        return this;
    }

    public IPersonalComputerUpdater UpdateBios(Bios bios)
    {
        _bios = bios;
        return this;
    }

    public IPersonalComputerUpdater UpdateRam(Ram ram)
    {
        _ram = ram;
        return this;
    }

    public IPersonalComputerUpdater UpdateGpu(Gpu gpu)
    {
        _gpu = gpu;
        return this;
    }

    public IPersonalComputerUpdater UpdateCoolingSystem(CoolingSystem coolingSystem)
    {
        _coolingSystem = coolingSystem;
        return this;
    }

    public IPersonalComputerUpdater UpdateHdd(Hdd hdd)
    {
        _hdd = hdd;
        return this;
    }

    public IPersonalComputerUpdater UpdateSsd(Ssd ssd)
    {
        _ssd = ssd;
        return this;
    }

    public IPersonalComputerUpdater UpdateWifiAdapter(WifiAdapter wifiAdapter)
    {
        _wifiAdapter = wifiAdapter;
        return this;
    }

    public IPersonalComputerUpdater UpdateXmpProfile(XmpProfile xmpProfile)
    {
        _xmpProfile = xmpProfile;
        return this;
    }

    public Pc Update()
    {
        _pc = new Pc(_computerCase, _psu, _motherboard, _cpu, _bios, _ram, _gpu, _coolingSystem, _hdd, _ssd, _wifiAdapter, _xmpProfile);
        Configurator.ValidConfigurationCheck(_pc);
        return _pc;
    }
}
