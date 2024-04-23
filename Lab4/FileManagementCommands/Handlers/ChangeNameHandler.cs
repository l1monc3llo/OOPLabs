using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class ChangeNameHandler : Handler
{
    private FileInfo? _file;
    private string? _newName;

    public static bool IsChangeNameCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 4 || requestWords[0] != "file" || requestWords[1] != "rename")
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(requestWords[2]) || string.IsNullOrWhiteSpace(requestWords[3]))
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

        if (string.IsNullOrWhiteSpace(request))
        {
            throw new ArgumentException("Request cannot be null or white space");
        }

        string[] words = request.Split(' ');

        if (!IsChangeNameCommandRequest(words))
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

        string filePath = Path.Combine(requestAcceptor.Directory.FullName, words[2]);
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"File '{filePath}' does not exist.");
            return;
        }

        _file = new FileInfo(filePath);
        _newName = words[3];
        var command = new ChangeNameCommand(_file, _newName, requestAcceptor.FileSystemManager);
        command.Execute();
    }
}