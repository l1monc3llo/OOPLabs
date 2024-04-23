using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers.Entities;
public class Messenger : IMessenger
{
    public Messenger(IMessage? message)
    {
        CurrentMessage = message;
    }

    public IMessage? CurrentMessage { get; private set; }

    public void ReceiveMessage(IMessage message)
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

        Console.WriteLine($"Messenger: {CurrentMessage.Body}");
    }
}