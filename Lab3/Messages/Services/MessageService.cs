using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Services;

public static class MessageService
{
    public static IMessage MarkMessageAsRead(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (message is AlreadyReadMessage)
        {
            throw new InvalidOperationException("Message canon be marked as read twice");
        }

        return new AlreadyReadMessage(message);
    }
}