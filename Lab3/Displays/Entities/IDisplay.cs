using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;

public interface IDisplay
{
    void GetMessage(IMessage message);
    void ShowMessage();
}