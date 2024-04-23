using Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Services;

namespace Itmo.ObjectOrientedProgramming.Lab4.FileManagementCommands.Handlers;

public class Handler : IHandler
{
    public IHandler? NextHandler { get; private set; }

    public IHandler SetNext(IHandler nextHandler)
    {
        NextHandler = nextHandler;
        return NextHandler;
    }

    public virtual void Handle(string request, RequestAcceptor requestAcceptor)
    {
    }
}