namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public class DamageCritical : DamageType
{
    private const int DamageTypeCoefficient = 20;
    public DamageCritical()
        : base(DamageTypeCoefficient)
    {
    }
}