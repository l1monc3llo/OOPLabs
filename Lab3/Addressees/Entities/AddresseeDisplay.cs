using System;
using Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Addressees.Entities;

public class AddresseeDisplay : IAddressee
{
    public AddresseeDisplay(IDisplay display, ILogger<IDisplay>? logger)
    {
        Device = display;
        Logger = logger;
    }

    public IDisplay Device { get; }
    public ILogger<IDisplay>? Logger { get; }
    public void ReceiveMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        Logger?.LogMessage(message, Device);
        Device.GetMessage(message);
    }
}