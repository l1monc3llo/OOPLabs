using System;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Models;

public static class Damage
{
    private const int BaseDamage = 20;
    public static int DamageCalculation(DamageType damageType)
    {
        if (damageType is null)
        {
            throw new ArgumentNullException(nameof(damageType));
        }

        return BaseDamage * damageType.Coefficient;
    }
}
