using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class OrdinarySpace : Environment
{
    public OrdinarySpace(double distanceValue, IEnumerable<IObstacle> obstacles)
        : base(distanceValue, obstacles)
    {
    }

    public override void IsValidObstacleForAdding(IObstacle obstacle)
    {
        if (!(obstacle is Asteroid))
        {
            throw new ArgumentException("Invalid obstacle for adding in the environment");
        }
    }
}