using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;

public class Display
{
    public Display(IMessage? message, IDisplayDriver driver)
    {
        CurrentMessage = message;
        Driver = driver;
    }

    public IMessage? CurrentMessage { get; private set; }
    public IDisplayDriver Driver { get; }

    public void GetMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        CurrentMessage = message;
    }

    public void ShowMessage()
    {
        if (CurrentMessage is null)
        {
            throw new InvalidOperationException("No message to show");
        }

        Driver.WriteText(CurrentMessage);
    }
}