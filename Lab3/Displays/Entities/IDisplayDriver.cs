using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;

public interface IDisplayDriver
{
    void ClearOutput();
    void SetTextColor(ConsoleColor color);
    void WriteText(IMessage message);
}