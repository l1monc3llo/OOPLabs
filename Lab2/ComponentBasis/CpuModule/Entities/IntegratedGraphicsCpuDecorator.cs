namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Entities;

public class IntegratedGraphicsCpuDecorator : CpuDecorator
{
    public IntegratedGraphicsCpuDecorator(ICpu cpu)
        : base(cpu)
    {
    }
}