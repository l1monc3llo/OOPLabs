namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.PsuModule.Entities;

public class Psu
{
    public Psu(int peakLoadInW)
    {
        PeakLoadInW = peakLoadInW;
    }

    public int PeakLoadInW { get; }
}