using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class NeutrinoParticlesNebula : Environment
{
    public NeutrinoParticlesNebula(double distanceValue, IEnumerable<IObstacle> obstacles)
        : base(distanceValue, obstacles)
    {
    }

    public override void IsValidObstacleForAdding(IObstacle obstacle)
    {
        if (!(obstacle is SpaceWhale))
        {
            throw new ArgumentException("Invalid obstacle for adding in the environment");
        }
    }
}