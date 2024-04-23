using System;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.CpuModule.Models;

public class CoresNumberStandard
{
    public CoresNumberStandard(int coresNumber)
    {
        ValidateCoresNumber(coresNumber);
        Number = coresNumber;
    }

    public int Number { get; }

    public static void ValidateCoresNumber(int coresNumber)
    {
        if (coresNumber <= 0 || coresNumber % 2 != 0)
        {
            throw new ArgumentException("Cores number cannot be non-positive or not be a power of two");
        }
    }
}