using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Models;

public class RamSizeInGbStandard
{
    public RamSizeInGbStandard(int ramSize)
    {
        ValidateRamSize(ramSize);
        RamSize = ramSize;
    }

    public int RamSize { get; }

    public static void ValidateRamSize(int ramSize)
    {
        if (ramSize <= 0 || ramSize % 2 != 0)
        {
            throw new ArgumentException("RAM Size cannot be non-positive or not be a power of two");
        }
    }
}