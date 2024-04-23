using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class ConnectDirectoryHandler : Handler
{
    private DirectoryInfo? _directory;
    private RequestAcceptor? _requestAcceptor;
    public static bool IsConnectDirectoryCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 3 || requestWords[0] != "connect")
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(requestWords[1]) || string.IsNullOrWhiteSpace(requestWords[2]))
        {
            return false;
        }

        return true;
    }

    public override void Handle(string request, RequestAcceptor requestAcceptor)
    {
        if (requestAcceptor is null)
        {
            throw new ArgumentNullException(nameof(requestAcceptor));
        }

        _requestAcceptor = requestAcceptor;

        if (string.IsNullOrWhiteSpace(request))
        {
            throw new ArgumentException("Request cannot be null or white space");
        }

        string[] words = request.Split(' ');

        if (!IsConnectDirectoryCommandRequest(words))
        {
            if (NextHandler is null)
            {
                Console.WriteLine("Request is not handled and fuck u");
                return;
            }

            NextHandler.Handle(request, requestAcceptor);
            return;
        }

        if (requestAcceptor.Directory is not null)
        {
            throw new InvalidOperationException("A directory is already connected");
        }

        if (requestAcceptor.FileSystemManager.Mode.ConsoleFlag != words[2])
        {
            throw new InvalidOperationException("Unsupported connect mode.");
        }

        string directoryPath = words[1];

        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"Directory '{directoryPath}' does not exist.");
            return;
        }

        _directory = new DirectoryInfo(directoryPath);
        var command = new ConnectDirectoryCommand(_directory, _requestAcceptor);
        command.Execute();
    }
}