using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.HddModule.Models;

public class HddSizeInGbStandard
{
    public HddSizeInGbStandard(double hddSize)
    {
        ValidateHddSize(hddSize);
        Size = hddSize;
    }

    public double Size { get; }

    public static void ValidateHddSize(double hddSize)
    {
        if (hddSize <= 0 || hddSize % 500 != 0)
        {
            throw new ArgumentException("HDD Size must be a positive multiple of 500 GB");
        }
    }
}