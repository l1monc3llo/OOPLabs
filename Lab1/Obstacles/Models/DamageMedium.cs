namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public class DamageMedium : DamageType
{
    private const int DamageTypeCoefficient = 2;
    public DamageMedium()
        : base(DamageTypeCoefficient)
    {
    }
}