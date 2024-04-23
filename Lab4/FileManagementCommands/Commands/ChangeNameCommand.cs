using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Commands;

public class ChangeNameCommand : ICommand
{
    private FileInfo _file;
    private string _newName;
    private IFileSystemManager _manager;

    public ChangeNameCommand(FileInfo file, string newName, IFileSystemManager manager)
    {
        _file = file;
        _newName = newName;
        _manager = manager;
    }

    public void Execute()
    {
        _manager.FileRename(_file, _newName);
    }
}