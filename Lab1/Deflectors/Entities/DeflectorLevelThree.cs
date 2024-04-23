namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class DeflectorLevelThree : Deflector
{
    private const double FullHealthPoints = 400.0;
    private const double DissipationFactorLevel3 = 0.45;
    public DeflectorLevelThree()
        : base(FullHealthPoints, DissipationFactorLevel3)
    {
    }
}