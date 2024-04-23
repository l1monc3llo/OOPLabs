using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class CopyFileCommand : ICommand
{
    private FileInfo _file;
    private DirectoryInfo _targetDirectory;
    private IFileSystemManager _manager;

    public CopyFileCommand(FileInfo file, DirectoryInfo targetDirectory, IFileSystemManager manager)
    {
        _file = file;
        _targetDirectory = targetDirectory;
        _manager = manager;
    }

    public void Execute()
    {
        _manager.FileCopy(_file, _targetDirectory);
    }
}