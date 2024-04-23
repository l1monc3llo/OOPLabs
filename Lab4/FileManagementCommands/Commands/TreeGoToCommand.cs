using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class TreeGoToCommand : ICommand
{
    private DirectoryInfo _directory;
    private RequestAcceptor _requestAcceptor;

    public TreeGoToCommand(DirectoryInfo directory, RequestAcceptor requestAcceptor)
    {
        _directory = directory;
        _requestAcceptor = requestAcceptor;
    }

    public void Execute()
    {
        if (_directory is null)
        {
            throw new ArgumentNullException(nameof(_directory));
        }

        if (_requestAcceptor is null)
        {
            throw new ArgumentNullException(nameof(_requestAcceptor));
        }

        _requestAcceptor.ChangeDirectory(_directory);
    }
}