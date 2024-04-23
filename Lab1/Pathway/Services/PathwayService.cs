using System;
using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Pathway.Services;

public class PathwayService : IPathwayService
{
    private readonly List<Spaceship> _currentSpaceships;
    private readonly PathwayRoute _pathwayRoute;

    public PathwayService(PathwayRoute pathwayRoute, IEnumerable<Spaceship> spaceships)
    {
        _pathwayRoute = pathwayRoute;
        _currentSpaceships = new List<Spaceship>(spaceships);
    }

    public PathwayRoute Route => _pathwayRoute;
    public IReadOnlyCollection<Spaceship> CurrentSpaceships => _currentSpaceships;
    public void AddSpaceship(Spaceship spaceship)
    {
        if (spaceship == null)
            throw new ArgumentNullException(nameof(spaceship));

        _currentSpaceships.Add(spaceship);
    }

    public PathwayStatus PathwayCompletion(PathwayRoute route, Spaceship spaceship)
    {
        if (route == null || spaceship == null)
        {
            throw new ArgumentNullException(route == null ? nameof(route) : nameof(spaceship));
        }

        foreach (Environment environment in route.Route)
        {
            PathwayStatus status = environment.SummaryCalculation(spaceship);

            if (status != PathwayStatus.Success)
            {
                return status;
            }
        }

        return PathwayStatus.Success;
    }

    public Spaceship? FindBestSuitableSpaceship(PathwayRoute route)
    {
        if (route == null)
        {
            throw new ArgumentNullException(nameof(route));
        }

        double minimumFuelConsumed = double.MaxValue;
        Spaceship? bestSuitableSpaceship = null;
        foreach (Spaceship spaceship in CurrentSpaceships)
        {
            if (PathwayCompletion(route, spaceship) is not PathwayStatus.Success || route.FuelConsumptionInRoute(spaceship) >= minimumFuelConsumed)
            {
                continue;
            }

            bestSuitableSpaceship = spaceship;
            minimumFuelConsumed = route.FuelConsumptionInRoute(spaceship);
        }

        return bestSuitableSpaceship;
    }
}