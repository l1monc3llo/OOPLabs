using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;
using Itmo.ObjectOrientedProgramming.Lab3.Users.Models;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users.Entities;

public interface IUser
{
    Nickname UserName { get; }
    void ReceiveMessage(IMessage message);
}