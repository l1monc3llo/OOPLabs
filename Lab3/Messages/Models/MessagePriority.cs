using System;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

public class MessagePriority
{
    public MessagePriority(int priorityMessageLevel)
    {
        ValidateLevel(priorityMessageLevel);
        Level = priorityMessageLevel;
    }

    public int Level { get; }

    public static void ValidateLevel(int priorityMessageLevel)
    {
        if (priorityMessageLevel > 100 || priorityMessageLevel < 1)
        {
            throw new ArgumentException("Priority message level cannot be lesser than 1 and higher than 100");
        }
    }
}