namespace Itmo.ObjectOrientedProgramming.Lab1.Deflectors.Entities;

public class PhotonMod
{
    public int BurstDeflectionResource { get; private set; } = 3;

    public void GetBurstDamage()
    {
        BurstDeflectionResource -= 1;
    }
}