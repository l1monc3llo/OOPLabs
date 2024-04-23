using System;
using Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Engines.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.HullStrengthLevels.Entities;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Models;
using Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Objects;
namespace Itmo.ObjectOrientedProgramming.Lab1.Spaceships.Entities;

public class Spaceship
{
    public Spaceship(IPulseEngine pulseEngine, IWarpEngine? warpEngine, HullStrength hullStrength, Deflector? deflector, PhotonMod? deflectorMod, bool antiNeutrinoEmitter, MassAndSizeKind massAndSize)
    {
        PulseEngine = pulseEngine;
        WarpEngine = warpEngine;
        HullStrengthLevel = hullStrength;
        if (deflector == null && deflectorMod != null)
        {
            throw new ArgumentException("PhotonMod can not be installed on the spaceship without deflector");
        }

        Deflector = deflector;
        DeflectorMod = deflectorMod;
        AntiNeutrinoEmitter = antiNeutrinoEmitter;
        Crew = CrewStatus.Alive;
        MassAndSize = massAndSize;
    }

    public IPulseEngine PulseEngine { get; }
    public IWarpEngine? WarpEngine { get; }
    public HullStrength HullStrengthLevel { get; }
    public Deflector? Deflector { get; }
    public PhotonMod? DeflectorMod { get; }
    public bool AntiNeutrinoEmitter { get; }
    public CrewStatus Crew { get; private set; }
    public MassAndSizeKind MassAndSize { get; }

    public void ChangeCrewStatusToDead()
    {
        Crew = CrewStatus.Dead;
    }
}