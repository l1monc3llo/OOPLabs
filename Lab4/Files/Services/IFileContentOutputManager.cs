namespace Itmo.ObjectOrientedProgramming.Lab4.Files.Services;

public interface IFileContentOutputManager
{
    bool CanOutput(string requestedMode);
    void OutputContent(string content);
}