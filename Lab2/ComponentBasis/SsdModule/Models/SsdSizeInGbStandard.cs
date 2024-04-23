using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.SsdModule.Models;

public class SsdSizeInGbStandard
{
    public SsdSizeInGbStandard(double sizeSsd)
    {
        ValidateSsdSize(sizeSsd);
        Size = sizeSsd;
    }

    public double Size { get; }

    public static void ValidateSsdSize(double ssdSize)
    {
        if (ssdSize <= 0 || ssdSize % 125 != 0)
        {
            throw new ArgumentException("SDD Size must be a positive multiple of 125 GB");
        }
    }
}