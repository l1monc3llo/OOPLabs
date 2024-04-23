using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;
public class Augur : Spaceship
{
    public Augur(PhotonMod? deflectorMod)
        : base(new PulseClassE(), new WarpAlpha(), new HullStrengthLevelThree(), new DeflectorLevelThree(), deflectorMod, false, MassAndSizeKind.Big)
    {
    }
}
