using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class SpaceWhale : IObstacle
{
    public double CalculateDeflectorsDamage()
    {
        return Damage.DamageCalculation(new DamageCritical());
    }

    public double CalculateHullStrengthDamage()
    {
        return Damage.DamageCalculation(new DamageCritical());
    }

    public void CalculateSpaceshipDamage(Spaceship spaceship)
    {
        if (spaceship is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        if (spaceship.AntiNeutrinoEmitter == false)
        {
            if (spaceship.Deflector is not null && spaceship.Deflector.HealthPoints > 0)
            {
                spaceship.Deflector.GetDamage(CalculateDeflectorsDamage());
                if (spaceship.Deflector.HealthPoints < 0)
                {
                    double transientDamage = double.Abs(spaceship.Deflector.HealthPoints);
                    spaceship.HullStrengthLevel.GetDamage(transientDamage);
                }
            }
            else
            {
                spaceship.HullStrengthLevel.GetDamage(CalculateHullStrengthDamage());
            }
        }
    }
}