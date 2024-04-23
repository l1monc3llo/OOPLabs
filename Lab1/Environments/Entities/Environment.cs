using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Models;

namespace Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities;

public class Environment
{
    private readonly List<IObstacle> _obstacles;

    public Environment(double distanceValue, IEnumerable<IObstacle> obstacles)
    {
        DistanceValue = distanceValue;
        _obstacles = obstacles.ToList();
    }

    public double DistanceValue { get; private set; }
    public IReadOnlyCollection<IObstacle> Obstacles => _obstacles;

    public void AddObstacle(IObstacle obstacle)
    {
        IsValidObstacleForAdding(obstacle);
        _obstacles.Add(obstacle);
    }

    public virtual void IsValidObstacleForAdding(IObstacle obstacle)
    {
    }

    public virtual PathwayStatus SummaryCalculation(Spaceship ship)
    {
        if (ship is null)
        {
            throw new ArgumentNullException(nameof(ship));
        }

        foreach (IObstacle obstacle in Obstacles)
        {
            obstacle.CalculateSpaceshipDamage(ship);
        }

        if (ship.HullStrengthLevel.HealthPoints <= 0)
        {
            return PathwayStatus.ShipDestroyed;
        }

        if (ship.Crew == CrewStatus.Dead)
        {
            return PathwayStatus.CrewLoss;
        }

        return PathwayStatus.Success;
    }

    public virtual double FuelConsumptionInEnvironment(Spaceship spaceship)
    {
        if (spaceship is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        if (spaceship.PulseEngine is null)
        {
            throw new InvalidOperationException("PulseEngine is not initialized.");
        }

        return spaceship.PulseEngine.CalculateFuelConsumption(DistanceValue);
    }
}