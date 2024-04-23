namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public class DamageZero : DamageType
{
    private const int DamageTypeCoefficient = 0;
    public DamageZero()
        : base(DamageTypeCoefficient)
    {
    }
}