using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messengers.Entities;

public interface IMessenger
{
    void ReceiveMessage(IMessage message);
    void ShowMessage();
}