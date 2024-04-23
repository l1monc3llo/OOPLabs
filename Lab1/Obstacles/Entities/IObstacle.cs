using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab1.Obstacles.Entities;

public interface IObstacle
{
    double CalculateDeflectorsDamage();
    double CalculateHullStrengthDamage();
    void CalculateSpaceshipDamage(Spaceship spaceship);
}