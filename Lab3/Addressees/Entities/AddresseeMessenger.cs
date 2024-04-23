using System;
using Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messengers.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Entities;

public class AddresseeMessenger : IAddressee
{
    public AddresseeMessenger(IMessenger messenger, ILogger<IMessenger>? logger)
    {
        App = messenger;
        Logger = logger;
    }

    public IMessenger App { get; }
    public ILogger<IMessenger>? Logger { get; }
    public void ReceiveMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        Logger?.LogMessage(message, App);
        App.ReceiveMessage(message);
    }
}