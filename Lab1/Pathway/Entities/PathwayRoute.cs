using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;
using Environment = Itmo.ObjectOrientedProgramming.Lab1.Environments.Entities.Environment;

namespace Itmo.ObjectOrientedProgramming.Lab1.Pathway.Entities;

public class PathwayRoute
{
    private readonly List<Environment> _pathwayRoute;
    public PathwayRoute(IEnumerable<Environment> pathwayRoute)
    {
        _pathwayRoute = pathwayRoute.ToList();
    }

    public IReadOnlyCollection<Environment> Route => _pathwayRoute;

    public void AddEnvironment(Environment environment)
    {
        if (environment == null)
            throw new ArgumentNullException(nameof(environment));

        _pathwayRoute.Add(environment);
    }

    public double FuelConsumptionInRoute(Spaceship spaceship)
    {
        if (Route is null)
        {
            throw new ArgumentNullException(nameof(spaceship));
        }

        double allFuelConsumed = 0;
        foreach (Environment environment in Route)
        {
            allFuelConsumed += environment.FuelConsumptionInEnvironment(spaceship);
        }

        return allFuelConsumed;
    }
}
