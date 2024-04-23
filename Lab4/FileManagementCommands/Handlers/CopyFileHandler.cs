using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class CopyFileHandler : Handler
{
    private FileInfo? _file;
    private DirectoryInfo? _targetDirectory;
    public static bool IsCopyFileCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 4 || requestWords[0] != "file" || requestWords[1] != "copy")
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

        if (!IsCopyFileCommandRequest(words))
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
        string newFilePath = Path.Combine(requestAcceptor.Directory.FullName,  words[3]);
        _targetDirectory = new DirectoryInfo(newFilePath);
        var command = new CopyFileCommand(_file, _targetDirectory, requestAcceptor.FileSystemManager);
        command.Execute();
    }
}