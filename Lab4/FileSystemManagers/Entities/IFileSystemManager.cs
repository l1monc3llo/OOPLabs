using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Files.Services;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

public interface IFileSystemManager
{
    ConnectMode Mode { get; }
    void FileRename(FileInfo file, string newName);
    void FileCopy(FileInfo file, DirectoryInfo targetDirectory);
    void FileDelete(FileInfo file);
    void ShowFileContent(FileInfo file, IFileContentOutputManager outputManager);
}