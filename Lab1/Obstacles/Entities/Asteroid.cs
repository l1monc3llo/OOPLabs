using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class Asteroid : IObstacle
{
    public double CalculateDeflectorsDamage()
    {
        return Damage.DamageCalculation(new DamageLow());
    }

    public double CalculateHullStrengthDamage()
    {
        return Damage.DamageCalculation(new DamageMedium());
    }

    public void CalculateSpaceshipDamage(Spaceship spaceship)
    {
        if (spaceship is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        if (spaceship.Deflector is null || spaceship.Deflector.HealthPoints <= 0)
        {
            spaceship.HullStrengthLevel.GetDamage(CalculateHullStrengthDamage());
            return;
        }

        if (spaceship.Deflector.HealthPoints > 0)
        {
            spaceship.Deflector.GetDamage(CalculateDeflectorsDamage());
        }

        if (spaceship.Deflector.HealthPoints < 0)
        {
            spaceship.HullStrengthLevel.GetDamage(Math.Abs(spaceship.Deflector.HealthPoints));
        }
    }
}