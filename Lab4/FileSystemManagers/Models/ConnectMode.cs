namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Models;

public class ConnectMode
{
    public ConnectMode(ConnectionType connectionType, string consoleFlag)
    {
        RequiredConnection = connectionType;
        ConsoleFlag = consoleFlag;
    }

    public ConnectionType RequiredConnection { get; }
    public string ConsoleFlag { get; }
}