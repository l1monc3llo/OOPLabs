using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;
using Itmo.ObjectOrientedProgramming.Lab4.Files.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class ShowFileContentHandler : Handler
{
    private readonly List<IFileContentOutputManager> _supportedFileContentOutputManagers;
    private FileInfo? _file;
    private string? _requestedOutputManager;
    public ShowFileContentHandler(IEnumerable<IFileContentOutputManager> supportedFileContentOutputManagers)
    {
        _supportedFileContentOutputManagers = supportedFileContentOutputManagers.ToList();
    }

    public IEnumerable<IFileContentOutputManager> SupportedFileContentOutputManagers => _supportedFileContentOutputManagers;
    public static bool IsShowFileContentCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 4 || requestWords[0] != "file" || requestWords[1] != "show")
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

        if (!IsShowFileContentCommandRequest(words))
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
        _requestedOutputManager = words[3];
        var command = new ShowFileContentCommand(_supportedFileContentOutputManagers, _file, _requestedOutputManager, requestAcceptor.FileSystemManager);
        command.Execute();
    }
}