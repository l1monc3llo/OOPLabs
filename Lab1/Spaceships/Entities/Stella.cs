using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

public class Stella : Spaceship
{
    public Stella(PhotonMod? deflectorMod)
        : base(new PulseClassC(), new WarpOmega(), new HullStrengthLevelOne(), new DeflectorLevelOne(), deflectorMod, false, MassAndSizeKind.Small)
    {
    }
}