using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public class UserProxyLogger : IProxyLogger
{
    public void LogForwardedMessage(IMessage message, IUser recipient)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (recipient is null)
        {
            throw new ArgumentNullException(nameof(recipient));
        }

        Console.WriteLine(
            $"UserProxy: Message priority is high. Message is forwarded to recipient {recipient.UserName.Name}.");
    }

    public void LogUnForwardedMessage(IMessage message, IUser recipient)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (recipient is null)
        {
            throw new ArgumentNullException(nameof(recipient));
        }

        Console.WriteLine(
            $"UserProxy: Message priority is too low. Message is not forwarded to recipient {recipient.UserName.Name}.");
    }
}