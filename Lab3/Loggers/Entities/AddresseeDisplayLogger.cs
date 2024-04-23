using System;
using Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;

public class AddresseeDisplayLogger : ILogger<IDisplay>
{
    public void LogMessage(IMessage message, IDisplay recipient)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (recipient is null)
        {
            throw new ArgumentNullException(nameof(recipient));
        }

        Console.WriteLine($"[{{currentTime}}]: Display got a new message to show");
    }
}