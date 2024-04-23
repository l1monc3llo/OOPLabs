using System;

namespace Itmo.ObjectOrientedProgramming.Lab4.Files.Services;

public class FileContentConsoleOutputManager : IFileContentOutputManager
{
    public void OutputContent(string content)
    {
        Console.WriteLine(content);
    }

    public bool CanOutput(string requestedMode)
    {
        if (string.IsNullOrWhiteSpace(requestedMode))
        {
            throw new ArgumentException("Requested mode info cannot be null or white space");
        }

        if (!requestedMode.Equals("console", StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        return true;
    }
}