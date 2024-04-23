using System;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public class AntimatterBurst : IObstacle
{
    public double CalculateDeflectorsDamage()
    {
        return Damage.DamageCalculation(new DamageZero());
    }

    public double CalculateHullStrengthDamage()
    {
        return Damage.DamageCalculation(new DamageZero());
    }

    public void CalculateSpaceshipDamage(Spaceship spaceship)
    {
        if (spaceship is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        if (spaceship.Deflector is not null && spaceship.DeflectorMod is not null && spaceship.DeflectorMod.BurstDeflectionResource > 0)
        {
            spaceship.DeflectorMod.GetBurstDamage();
            spaceship.Deflector.GetDamage(CalculateDeflectorsDamage());
        }
        else if (spaceship.Crew is CrewStatus.Alive)
        {
            spaceship.ChangeCrewStatusToDead();
        }
    }
}
