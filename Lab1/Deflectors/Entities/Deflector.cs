using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class Deflector
{
    public Deflector(double healthPoints, double dissipationFactor)
    {
        HealthPoints = healthPoints;
        DissipationFactor = dissipationFactor;
    }

    public double HealthPoints { get; private set; }
    public double DissipationFactor { get; }

    public void GetDamage(double damage)
    {
        damage *= DissipationFactor;
        if (damage < 0)
        {
            throw new ArgumentException("Damage can not be negative");
        }

        HealthPoints -= damage;
    }
}