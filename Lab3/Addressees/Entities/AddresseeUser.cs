using System;
using Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Entities;

public class AddresseeUser : IAddressee
{
    public AddresseeUser(IUser recipient, ILogger<IUser>? logger)
    {
        Recipient = recipient;
        Logger = logger;
    }

    public IUser Recipient { get; }
    public ILogger<IUser>? Logger { get; }
    public void ReceiveMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        Logger?.LogMessage(message, Recipient);
        Recipient.ReceiveMessage(message);
    }
}