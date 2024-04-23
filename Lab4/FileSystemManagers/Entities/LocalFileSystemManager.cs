using System;
using System.IO;
using Itmo.ObjectOrientedProgramming.Lab4.Files.Services;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Models;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

public class LocalFileSystemManager : IFileSystemManager
{
    public ConnectMode Mode => new LocalConnectMode();
    public void FileRename(FileInfo file, string newName)
    {
        if (file is null)
        {
            throw new ArgumentNullException(nameof(file));
        }

        if (newName is null)
        {
            throw new ArgumentNullException(nameof(newName));
        }

        string directoryFullName = file.Directory?.FullName ?? string.Empty;
        string originalExtension = file.Extension;
        string newFilePath = Path.Combine(directoryFullName, newName + originalExtension);
        file.MoveTo(newFilePath);
    }

    public void FileCopy(FileInfo file, DirectoryInfo targetDirectory)
    {
        if (file is null)
        {
            throw new ArgumentNullException(nameof(file));
        }

        if (targetDirectory is null)
        {
            throw new ArgumentNullException(nameof(targetDirectory));
        }

        string newFilePath = Path.Combine(targetDirectory.FullName, file.Name);
        File.Copy(file.FullName, newFilePath);
        Console.WriteLine($"File '{file.FullName}' copied to '{newFilePath}'.");
    }

    public void FileDelete(FileInfo file)
    {
        if (file is null)
        {
            throw new InvalidOperationException("File is not specified");
        }

        File.Delete(file.FullName);
    }

    public void ShowFileContent(FileInfo file, IFileContentOutputManager outputManager)
    {
        if (file is null)
        {
            throw new InvalidOperationException("File is not specified");
        }

        if (outputManager is null)
        {
            throw new ArgumentNullException(nameof(outputManager));
        }

        string content = File.ReadAllText(file.FullName);
        outputManager.OutputContent(content);
    }
}
