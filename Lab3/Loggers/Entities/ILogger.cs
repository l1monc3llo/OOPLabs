using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public interface ILogger<in T>
{
    void LogMessage(IMessage message, T recipient);
}