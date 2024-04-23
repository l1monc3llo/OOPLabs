using Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

public class Message : IMessage
{
    public Message(MessageTitle title, MessageBody body, MessagePriority priority)
    {
        Title = title;
        Body = body;
        Priority = priority;
    }

    public MessageTitle Title { get;  }
    public MessageBody Body { get;  }
    public MessagePriority Priority { get;  }
}