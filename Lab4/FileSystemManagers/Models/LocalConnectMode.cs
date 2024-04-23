namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Models;

public class LocalConnectMode : ConnectMode
{
    public LocalConnectMode()
        : base(ConnectionType.Offline, "local")
    {
    }
}