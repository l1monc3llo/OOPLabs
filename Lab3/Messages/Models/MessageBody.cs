using System;
using System.Text.RegularExpressions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

public class MessageBody
{
    private const string BodyPattern = @"^\w+.*$";
    private static readonly Regex BodyRegex = new Regex(BodyPattern, RegexOptions.Compiled);

    public MessageBody(string text)
    {
        Text = text;
    }

    public string Text { get; }
    public static void ValidateBody(string title)
    {
        if (!BodyRegex.IsMatch(title))
        {
            throw new ArgumentException("Body must not be empty for a message");
        }
    }
}