using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class TreeListHandler : Handler
{
    private int? _depth;
    private string? _fileSymbol;
    private string? _directorySymbol;

    public TreeListHandler(string? fileSymbol, string? directorySymbol)
    {
        _fileSymbol = fileSymbol;
        _directorySymbol = directorySymbol;
    }

    public DirectoryInfo? Directory { get; private set; }
    public static bool IsTreeListCommandRequest(string[] requestWords)
    {
        if (requestWords is null)
        {
            throw new ArgumentNullException(nameof(requestWords));
        }

        if (requestWords.Length != 3 || requestWords[0] != "tree" || requestWords[1] != "list")
        {
            return false;
        }

        if (!int.TryParse(requestWords[2], out _))
        {
            return false;
        }

        return true;
    }

    public override void Handle(string request, RequestAcceptor requestAcceptor)
    {
        if (string.IsNullOrWhiteSpace(request))
        {
            throw new ArgumentException("Request cannot be null or white space");
        }

        string[] words = request.Split(' ');

        if (!IsTreeListCommandRequest(words))
        {
            if (NextHandler is null)
            {
                Console.WriteLine("Request is not handled");
                return;
            }

            NextHandler.Handle(request, requestAcceptor);
            return;
        }

        if (requestAcceptor is null)
        {
            throw new ArgumentNullException(nameof(requestAcceptor));
        }

        if (requestAcceptor.Directory is null)
        {
            throw new InvalidOperationException("Directory is not specified.");
        }

        if (!int.TryParse(words[2], out int parsedDepth))
        {
            throw new ArgumentException("Depth must be an integer");
        }

        _depth = parsedDepth;
        Directory = requestAcceptor.Directory;
        var command = new TreeListCommand(_depth.Value, Directory, _fileSymbol, _directorySymbol);
        command.Execute();
    }
}