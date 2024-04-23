using System;
using Itmo.ObjectOrientedProgramming.Lab3.Loggers.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

public class UserProxy : IUser
{
    private readonly IUser _user;

    public UserProxy(IUser user, MessagePriority minimalMessagePriority, UserProxyLogger? logger)
    {
        _user = user;
        MinimalMessagePriority = minimalMessagePriority;
        Logger = logger;
    }

    public Nickname UserName => _user.UserName;
    public MessagePriority MinimalMessagePriority { get; }
    public UserProxyLogger? Logger { get; }
    public void ReceiveMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        if (message.Priority.Level > MinimalMessagePriority.Level)
        {
            Logger?.LogUnForwardedMessage(message, _user);
            return;
        }

        Logger?.LogUnForwardedMessage(message, _user);
        _user.ReceiveMessage(message);
    }
}