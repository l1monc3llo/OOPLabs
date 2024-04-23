using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

public class Meridian : Spaceship
{
    public Meridian(PhotonMod? deflectorMod)
        : base(new PulseClassE(), null, new HullStrengthLevelTwo(), new DeflectorLevelTwo(), deflectorMod, true, MassAndSizeKind.Medium)
    {
    }
}