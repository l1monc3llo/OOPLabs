namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorLevelOne : Deflector
{
    private const double FullHealthPoints = 50.0;
    private const double DissipationFactorLevel1 = 0.75;
    public DeflectorLevelOne()
        : base(FullHealthPoints, DissipationFactorLevel1)
    {
    }
}