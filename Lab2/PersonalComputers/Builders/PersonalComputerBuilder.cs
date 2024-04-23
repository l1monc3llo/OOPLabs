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

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Builders;

public class PersonalComputerBuilder
    {
        private ComputerCase? _computerCase;
        private Psu? _psu;
        private Motherboard? _motherboard;
        private Cpu? _cpu;
        private Bios? _bios;
        private Ram? _ram;
        private Gpu? _gpu;
        private CoolingSystem? _coolingSystem;
        private Hdd? _hdd;
        private Ssd? _ssd;
        private WifiAdapter? _wifiAdapter;
        private XmpProfile? _xmpProfile;
        public PersonalComputerBuilder WithComputerCase(ComputerCase computerCase)
        {
            _computerCase = computerCase;
            return this;
        }

        public PersonalComputerBuilder WithPsu(Psu psu)
        {
            _psu = psu;
            return this;
        }

        public PersonalComputerBuilder WithMotherboard(Motherboard motherboard)
        {
            _motherboard = motherboard;
            return this;
        }

        public PersonalComputerBuilder WithCpu(Cpu cpu)
        {
            _cpu = cpu;
            return this;
        }

        public PersonalComputerBuilder WithBios(Bios bios)
        {
            _bios = bios;
            return this;
        }

        public PersonalComputerBuilder WithRam(Ram ram)
        {
            _ram = ram;
            return this;
        }

        public PersonalComputerBuilder WithGpu(Gpu gpu)
        {
            _gpu = gpu;
            return this;
        }

        public PersonalComputerBuilder WithCoolingSystem(CoolingSystem coolingSystem)
        {
            _coolingSystem = coolingSystem;
            return this;
        }

        public PersonalComputerBuilder WithHdd(Hdd hdd)
        {
            _hdd = hdd;
            return this;
        }

        public PersonalComputerBuilder WithSsd(Ssd ssd)
        {
            _ssd = ssd;
            return this;
        }

        public PersonalComputerBuilder WithWifiAdapter(WifiAdapter wifiAdapter)
        {
            _wifiAdapter = wifiAdapter;
            return this;
        }

        public PersonalComputerBuilder WithXmpProfile(XmpProfile xmpProfile)
        {
            _xmpProfile = xmpProfile;
            return this;
        }

        public Pc Build()
        {
            var pc = new Pc(_computerCase, _psu, _motherboard, _cpu, _bios, _ram, _gpu, _coolingSystem, _hdd, _ssd, _wifiAdapter, _xmpProfile);
            Configurator.ValidConfigurationCheck(pc);
            return pc;
        }
    }