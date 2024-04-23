using System.Collections.Generic;
using Itmo.ObjectOrientedProgramming.Lab4.Apps.Entities;
using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;
using Itmo.ObjectOrientedProgramming.Lab4.Files.Services;
using Itmo.ObjectOrientedProgramming.Lab4.FileSystemManagers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab4;

public static class Program
{
    public static void Main()
    {
        IHandler commandChain = new ConnectDirectoryHandler();
        commandChain.SetNext(new DisconnectDirectoryHandler())
            .SetNext(new ShowFileContentHandler(new List<IFileContentOutputManager> { new FileContentConsoleOutputManager() }))
            .SetNext(new TreeListHandler("(file)", "(folder)"))
            .SetNext(new ChangeNameHandler())
            .SetNext(new CopyFileHandler())
            .SetNext(new DeleteFileHandler())
            .SetNext(new TreeGoToHandler());
        var localFileSystemManager = new LocalFileSystemManager();
        var consoleApp = new ConsoleApp(commandChain, localFileSystemManager);
        consoleApp.Run();
    }
}