using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.MotherboardModule.Models;

public class RamSlotsNumberStandard
{
    public RamSlotsNumberStandard(int ramSlotsNumber)
    {
        ValidateRamSlotsNumber(ramSlotsNumber);
        RamSlotsNumber = ramSlotsNumber;
    }

    public int RamSlotsNumber { get; }
    public static void ValidateRamSlotsNumber(int ramSlotsNumber)
    {
        if (ramSlotsNumber <= 0 || ramSlotsNumber % 2 != 0)
        {
            throw new ArgumentException("RAM slots number cannot be non-positive or not be a power of two");
        }
    }
}