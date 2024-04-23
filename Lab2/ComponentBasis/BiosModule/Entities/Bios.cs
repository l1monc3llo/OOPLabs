using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.BiosModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.BiosModule.Entities;

public class Bios
{
    private readonly List<CpuVariety> _supportedCpus;

    public Bios(
        BiosType type,
        BiosVersion version,
        IEnumerable<CpuVariety> supportedCpus)
    {
        Type = type;
        Version = version;
        _supportedCpus = supportedCpus.ToList();
    }

    public BiosType Type { get;  }
    public BiosVersion Version { get;  }
    public IReadOnlyCollection<CpuVariety> SupportedCpus => _supportedCpus;
}