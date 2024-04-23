using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

public class Vaklas : Spaceship
{
    public Vaklas(PhotonMod? deflectorMod)
        : base(new PulseClassE(), new WarpGamma(), new HullStrengthLevelTwo(), new DeflectorLevelOne(), deflectorMod, false, MassAndSizeKind.Medium)
    {
    }
}