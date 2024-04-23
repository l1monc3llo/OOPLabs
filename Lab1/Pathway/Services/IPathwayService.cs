using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Pathway.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Pathway.Services;

public interface IPathwayService
{
    void AddSpaceship(Spaceship spaceship);
    PathwayStatus PathwayCompletion(PathwayRoute route, Spaceship spaceship);
    Spaceship? FindBestSuitableSpaceship(PathwayRoute route);
}