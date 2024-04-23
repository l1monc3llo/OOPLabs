namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public class DamageLow : DamageType
{
    private const int DamageTypeCoefficient = 1;
    public DamageLow()
        : base(DamageTypeCoefficient)
    {
    }
}