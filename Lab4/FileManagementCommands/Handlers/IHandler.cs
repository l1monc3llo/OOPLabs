using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public interface IHandler
{
    IHandler SetNext(IHandler nextHandler);
    void Handle(string request, RequestAcceptor requestAcceptor);
}