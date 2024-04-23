using Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

public class MessageDecorator : IMessage
{
    private readonly IMessage _message;

    public MessageDecorator(IMessage message)
    {
        _message = message;
    }

    public MessageTitle Title => _message.Title;
    public MessageBody Body => _message.Body;
    public MessagePriority Priority => _message.Priority;
}