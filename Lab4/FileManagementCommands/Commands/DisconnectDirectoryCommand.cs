using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class DisconnectDirectoryCommand : ICommand
{
    private RequestAcceptor _requestAcceptor;
    public DisconnectDirectoryCommand(RequestAcceptor requestAcceptor)
    {
        _requestAcceptor = requestAcceptor;
    }

    public void Execute()
    {
        if (_requestAcceptor is null)
        {
            throw new ArgumentNullException(nameof(_requestAcceptor));
        }

        _requestAcceptor.ChangeDirectory(null);
        Console.WriteLine("Directory is disconnected");
    }
}