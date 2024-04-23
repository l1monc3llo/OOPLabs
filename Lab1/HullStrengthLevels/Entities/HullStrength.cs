namespace Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;

public class HullStrength
{
    public HullStrength(double healthPoints)
    {
        HealthPoints = healthPoints;
    }

    public double HealthPoints { get; private set; }

    public void GetDamage(double damage)
    {
        if (damage > 0)
        {
            HealthPoints -= damage;
        }
    }
}