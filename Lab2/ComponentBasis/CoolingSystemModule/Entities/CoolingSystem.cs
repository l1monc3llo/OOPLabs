using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CoolingSystemModule.Models;
using Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CoolingSystemModule.Entities;

public class CoolingSystem
{
    private readonly List<SocketType> _supportedSockets;
    public CoolingSystem(
        CoolingSystemDimensions dimensions,
        IEnumerable<SocketType> supportedSockets,
        int maxTdp)
    {
        Dimensions = dimensions;
        _supportedSockets = supportedSockets.ToList();
        MaxTdp = maxTdp;
    }

    public CoolingSystemDimensions Dimensions { get; }
    public IReadOnlyCollection<SocketType> SupportedSockets => _supportedSockets;
    public int MaxTdp { get; }
}