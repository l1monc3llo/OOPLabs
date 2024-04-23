using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab4.Files.Services;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class ShowFileContentCommand : ICommand
{
    private readonly List<IFileContentOutputManager> _supportedFileContentOutputManagers;
    private FileInfo _file;
    private string _requestedOutputManager;
    private IFileSystemManager _manager;

    public ShowFileContentCommand(IEnumerable<IFileContentOutputManager> supportedFileContentOutputManagers, FileInfo file, string requestedOutputManager, IFileSystemManager manager)
    {
        _supportedFileContentOutputManagers = supportedFileContentOutputManagers.ToList();
        _file = file;
        _requestedOutputManager = requestedOutputManager;
        _manager = manager;
    }

    public void Execute()
    {
        if (_file is null)
        {
            throw new InvalidOperationException("File is not specified");
        }

        if (_requestedOutputManager is null)
        {
            throw new InvalidOperationException("Content Output Manager is not specified");
        }

        foreach (IFileContentOutputManager outputManager in _supportedFileContentOutputManagers)
        {
            if (!outputManager.CanOutput(_requestedOutputManager))
            {
                continue;
            }

            _manager.ShowFileContent(_file, outputManager);
            return;
        }

        Console.WriteLine("Content was not output: no supported managers");
    }
}