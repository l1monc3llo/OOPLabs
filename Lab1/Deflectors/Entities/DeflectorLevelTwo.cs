namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorLevelTwo : Deflector
{
    private const double FullHealthPoints = 80.0;
    private const double DissipationFactorLevel2 = 0.6;
    public DeflectorLevelTwo()
        : base(FullHealthPoints, DissipationFactorLevel2)
    {
    }
}