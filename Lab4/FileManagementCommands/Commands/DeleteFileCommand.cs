using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class DeleteFileCommand : ICommand
{
    private FileInfo _file;
    private IFileSystemManager _manager;

    public DeleteFileCommand(FileInfo file, IFileSystemManager manager)
    {
        _file = file;
        _manager = manager;
    }

    public void Execute()
    {
        _manager.FileDelete(_file);
    }
}