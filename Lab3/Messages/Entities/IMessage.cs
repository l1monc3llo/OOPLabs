using Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

public interface IMessage
{
    MessageTitle Title { get;  }
    MessageBody Body { get;  }
    MessagePriority Priority { get;  }
}