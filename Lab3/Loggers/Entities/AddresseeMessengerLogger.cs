using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public class AddresseeMessengerLogger : ILogger<IMessenger>
{
    public void LogMessage(IMessage message, IMessenger recipient)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (recipient is null)
        {
            throw new ArgumentNullException(nameof(recipient));
        }

        Console.WriteLine($"[{{currentTime}}]: Messenger got a new message to show");
    }
}