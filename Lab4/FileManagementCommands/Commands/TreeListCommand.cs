using System;
using System.IO;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class TreeListCommand : ICommand
{
    private int _depth;
    private string? _fileSymbol;
    private string? _directorySymbol;

    public TreeListCommand(int depth, DirectoryInfo directory, string? fileSymbol, string? directorySymbol)
    {
        _depth = depth;
        Directory = directory;
        _fileSymbol = fileSymbol;
        _directorySymbol = directorySymbol;
    }

    public DirectoryInfo Directory { get; private set; }

    public void Execute()
    {
        ShowTree(Directory, _depth, 0, _fileSymbol, _directorySymbol);
    }

    private static string GetIndentation(int depth)
    {
        return new string('-', depth * 2);
    }

    private void ShowTree(DirectoryInfo directory, int depth, int currentDepth, string? fileSymbol, string? directorySymbol)
    {
        if (currentDepth > depth)
        {
            return;
        }

        foreach (DirectoryInfo subdirectory in directory.GetDirectories())
        {
            Console.WriteLine(GetIndentation(currentDepth + 1) + directorySymbol + subdirectory.Name);
            if (currentDepth < depth)
            {
                ShowTree(subdirectory, depth, currentDepth + 1, fileSymbol, directorySymbol);
            }
        }

        foreach (FileInfo file in directory.GetFiles())
        {
            Console.WriteLine(GetIndentation(currentDepth + 1) + fileSymbol + file.Name);
        }
    }
}