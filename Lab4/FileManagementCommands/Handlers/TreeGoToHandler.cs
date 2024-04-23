using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class TreeGoToHandler : Handler
{
    private DirectoryInfo? _directory;
    private RequestAcceptor? _requestAcceptor;
    public static bool IsTreeGoToCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 3 || requestWords[0] != "tree" || requestWords[1] != "goto")
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(requestWords[2]))
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

        if (!IsTreeGoToCommandRequest(words))
        {
            if (NextHandler is null)
            {
                Console.WriteLine("Request is not handled");
                return;
            }

            NextHandler.Handle(request, requestAcceptor);
            return;
        }

        if (requestAcceptor.Directory is null)
        {
            throw new InvalidOperationException("The directory is not connected");
        }

        string directoryPath = Path.Combine(requestAcceptor.Directory.FullName, words[2]);
        if (!Directory.Exists(directoryPath))
        {
            Console.WriteLine($"File '{directoryPath}' does not exist.");
            return;
        }

        _directory = new DirectoryInfo(directoryPath);
        var command = new TreeGoToCommand(_directory, _requestAcceptor);
        command.Execute();
    }
}