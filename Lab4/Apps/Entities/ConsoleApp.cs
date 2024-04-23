using System;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.Apps.Entities;

public class ConsoleApp
{
    private readonly RequestAcceptor _requestAcceptor;

    public ConsoleApp(IHandler commandChain, IFileSystemManager fileSystemManager)
    {
        _requestAcceptor = new RequestAcceptor(commandChain, fileSystemManager);
    }

    public void Run()
    {
        Console.WriteLine("Welcome");
        while (true)
        {
            Console.Write("Enter command: ");
            string? userInput = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userInput))
            {
                continue;
            }

            if (userInput == "exit")
            {
                break;
            }

            _requestAcceptor.AcceptRequest(userInput);
        }

        Console.WriteLine("Goodbye");
    }
}