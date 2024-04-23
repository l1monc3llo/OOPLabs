using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public interface IProxyLogger
{
    void LogForwardedMessage(IMessage message, IUser recipient);
    void LogUnForwardedMessage(IMessage message, IUser recipient);
}