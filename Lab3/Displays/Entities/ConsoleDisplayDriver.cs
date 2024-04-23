using System;
using Itmo.ObjectOrientedProgramming.Lab3.Messages.Entities;

namespace Itmo.ObjectOrientedProgramming.Lab3.Displays.Entities;

public class ConsoleDisplayDriver : IDisplayDriver
{
    public void ClearOutput()
    {
        Console.Clear();
    }

    public void SetTextColor(ConsoleColor color)
    {
        Console.ForegroundColor = color;
    }

    public void WriteText(IMessage message)
    {
        if (message is null)
        {
            throw new ArgumentNullException(nameof(message));
        }

        ClearOutput();
        Console.WriteLine(message.Body);
    }
}