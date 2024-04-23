using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class HighDensityNebula : Environment
{
    public HighDensityNebula(double distanceValue, IEnumerable<IObstacle> obstacles)
        : base(distanceValue, obstacles)
    {
    }

    public override void IsValidObstacleForAdding(IObstacle obstacle)
    {
        if (!(obstacle is AntimatterBurst))
        {
            throw new ArgumentException("Invalid obstacle for adding in the environment");
        }
    }

    public override PathwayStatus SummaryCalculation(Spaceship ship)
    {
        if (ship is null)
        {
            throw new ArgumentNullException(nameof(ship));
        }

        if (ship.WarpEngine is null)
        {
            return PathwayStatus.UnsuitableSpaceship;
        }

        if (DistanceValue > ship.WarpEngine.TravelingRange)
        {
            return PathwayStatus.ShipLoss;
        }

        return base.SummaryCalculation(ship);
    }

    public override double FuelConsumptionInEnvironment(Spaceship spaceship)
    {
        if (spaceship is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        if (spaceship.WarpEngine is null)
        {
            throw new InvalidOperationException("WarpEngine is not initialized.");
        }

        return spaceship.WarpEngine.CalculateFuelConsumption(DistanceValue);
    }
}
