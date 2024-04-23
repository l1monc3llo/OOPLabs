using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

public class RequestAcceptor
{
    public RequestAcceptor(IHandler? commandChain, IFileSystemManager fileSystemManager)
    {
        CommandChain = commandChain;
        FileSystemManager = fileSystemManager;
    }

    public DirectoryInfo? Directory { get; private set; }
    public IFileSystemManager FileSystemManager { get; }
    public IHandler? CommandChain { get; }

    public void AcceptRequest(string request)
    {
        if (CommandChain is null)
        {
            Console.WriteLine("Zero commands supported");
            return;
        }

        CommandChain.Handle(request, this);
    }

    public void ChangeDirectory(DirectoryInfo? directory)
    {
        Directory = directory;
    }
}
