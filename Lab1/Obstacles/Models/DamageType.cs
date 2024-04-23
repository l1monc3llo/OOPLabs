namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public class DamageType
{
    public DamageType(int coefficient)
    {
        Coefficient = coefficient;
    }

    public int Coefficient { get; }
}