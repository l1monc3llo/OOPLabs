using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public class AddresseeUserLogger : ILogger<IUser>
{
    public void LogMessage(IMessage message, IUser recipient)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (recipient is null)
        {
            throw new ArgumentNullException(nameof(recipient));
        }

        Console.WriteLine($"[{{currentTime}}]: User {recipient.UserName.Name} got a new message");
    }
}