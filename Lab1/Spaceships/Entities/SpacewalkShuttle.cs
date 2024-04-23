using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;

namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

public class SpacewalkShuttle : Spaceship
{
    public SpacewalkShuttle()
        : base(new PulseClassC(), null, new HullStrengthLevelOne(), null, null, false, MassAndSizeKind.Small)
    {
    }
}