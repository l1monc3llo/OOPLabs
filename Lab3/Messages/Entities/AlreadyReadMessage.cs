namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

public class AlreadyReadMessage : MessageDecorator
{
    public AlreadyReadMessage(IMessage message)
        : base(message)
    {
    }
}