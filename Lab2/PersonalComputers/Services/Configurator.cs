using System;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab2.PersonalComputers.Services;

public static class Configurator
    {
        public static void HavingAllNecessaryComponentsCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Motherboard is null || pc.Cpu is null || pc.CoolingSystem is null || (pc.Gpu is null && pc.Cpu is not IntegratedGraphicsCpuDecorator) || (pc.Ssd is null && pc.Hdd is null) || pc.Psu is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }
        }

        public static void MotherboardCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Motherboard is null || pc.ComputerCase is null || pc.Cpu is null || pc.Ram is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }

            if (!pc.ComputerCase.SupportedMotherboardFormFactors.Contains(pc.Motherboard.FormFactor))
            {
                throw new InvalidOperationException("The motherboard does not fit in the computer case");
            }

            if (pc.Motherboard.CpuSocket != pc.Cpu.Socket)
            {
                throw new InvalidOperationException("The CPU is incompatible with the motherboard");
            }

            foreach (JedecFrequencyAndVoltageStandard jedecFrequencyAndVoltage in pc.Ram.SupportedJedecFrequenciesAndVoltage)
            {
                double frequency = jedecFrequencyAndVoltage.Frequency;
                if (!pc.Motherboard.Chipset.SupportedMemoryFrequenciesInMhz.Contains(frequency))
                {
                    throw new InvalidOperationException("Incompatible RAM frequencies with the motherboard chipset");
                }
            }
        }

        public static void CpuCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Cpu is null || pc.Motherboard is null || pc.Bios is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }

            if (pc.Motherboard.CpuSocket != pc.Cpu.Socket)
            {
                throw new InvalidOperationException("The CPU is incompatible with the motherboard");
            }

            if (!pc.Bios.SupportedCpus.Contains(pc.Cpu.CpuModel))
            {
                throw new InvalidOperationException("The CPU is incompatible with the BIOS");
            }
        }

        public static void BiosCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Cpu is null || pc.Bios is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }
        }

        public static void RamCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Motherboard is null || pc.Ram is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }

            foreach (JedecFrequencyAndVoltageStandard jedecFrequencyAndVoltage in pc.Ram.SupportedJedecFrequenciesAndVoltage)
            {
                double frequency = jedecFrequencyAndVoltage.Frequency;
                if (!pc.Motherboard.Chipset.SupportedMemoryFrequenciesInMhz.Contains(frequency))
                {
                    throw new InvalidOperationException("Incompatible RAM frequencies with the motherboard chipset");
                }
            }
        }

        public static void GpuCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.Cpu is null || (pc.Gpu is null && pc.Cpu is not IntegratedGraphicsCpuDecorator) || pc.ComputerCase is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }

            if (pc.Gpu is null)
            {
                return;
            }

            if (pc.ComputerCase.MaxGpuHeightInInches < pc.Gpu.HeightInInches ||
                pc.ComputerCase.MaxGpuWidthInInches < pc.Gpu.WidthInInches)
            {
                throw new InvalidOperationException("The GPU is incompatible with the computer case");
            }
        }

        public static void ComputerCaseCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.ComputerCase is null || pc.Motherboard is null)
            {
                throw new InvalidOperationException("Unworkable configuration");
            }

            if (!pc.ComputerCase.SupportedMotherboardFormFactors.Contains(pc.Motherboard.FormFactor))
            {
                throw new InvalidOperationException("The motherboard does not fit in the computer case");
            }

            if (pc.Gpu is not null && (pc.ComputerCase.MaxGpuHeightInInches < pc.Gpu.HeightInInches ||
                                       pc.ComputerCase.MaxGpuWidthInInches < pc.Gpu.WidthInInches))
            {
                throw new InvalidOperationException("The GPU is incompatible with the computer case");
            }
        }

        public static void WifiAdapterCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.WifiAdapter is null)
            {
                return;
            }

            if (pc.Motherboard is null)
            {
                throw new InvalidOperationException("Configuration must contain the Motherboard");
            }

            if (pc.Motherboard.Chipset is IntegratedWifiModuleChipsetDecorator)
            {
                throw new InvalidOperationException("Network Hardware Conflict");
            }
        }

        public static void XmpProfileCompatibilityCheck(Pc pc)
        {
            if (pc is null)
            {
                throw new ArgumentNullException(nameof(pc));
            }

            if (pc.XmpProfile is null)
            {
                return;
            }

            if (pc.Motherboard is null)
            {
                throw new InvalidOperationException("Configuration must contain the Motherboard");
            }

            if (pc.Motherboard.Chipset is not XmlSupportChipsetDecorator)
            {
                throw new InvalidOperationException("The Motherboard chipset does not support XMP");
            }
        }

        public static void ValidConfigurationCheck(Pc pc)
        {
            HavingAllNecessaryComponentsCheck(pc);
            MotherboardCompatibilityCheck(pc);
            CpuCompatibilityCheck(pc);
            BiosCompatibilityCheck(pc);
            RamCompatibilityCheck(pc);
            GpuCompatibilityCheck(pc);
            ComputerCaseCompatibilityCheck(pc);
            WifiAdapterCompatibilityCheck(pc);
            XmpProfileCompatibilityCheck(pc);
        }
    }