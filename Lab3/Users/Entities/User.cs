using System;
using System.Collections.Generic;
using System.Linq;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Services;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

public class User : IUser
{
    private readonly List<IMessage> _userMessages;

    public User(Nickname name, IEnumerable<IMessage> userMessages)
    {
        UserName = name;
        _userMessages = userMessages.ToList();
    }

    public Nickname UserName { get; }
    public IEnumerable<IMessage> UserMessages => _userMessages;

    public void ReceiveMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        _userMessages.Add(message);
    }

    public void ReadMessage(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        IMessage? foundMessage = _userMessages.FirstOrDefault(messageInList => messageInList.Equals(message));
        if (foundMessage is null)
        {
            throw new ArgumentException("User does not have this message in the list");
        }

        if (!(foundMessage is AlreadyReadMessage))
        {
            IMessage markedMessage = MessageService.MarkMessageAsRead(foundMessage);
            _userMessages[_userMessages.IndexOf(foundMessage)] = markedMessage;
        }
    }
}