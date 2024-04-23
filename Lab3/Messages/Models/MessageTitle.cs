using System;
using System.Text.RegularExpressions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Messages.Models;

public class MessageTitle
{
    private const string TitlePattern = @"^\w+.*$";
    private static readonly Regex TitleRegex = new Regex(TitlePattern, RegexOptions.Compiled);

    public MessageTitle(string text)
    {
        Text = text;
    }

    public string Text { get; }
    public static void ValidateTitle(string title)
    {
        if (!TitleRegex.IsMatch(title))
        {
            throw new ArgumentException("Invalid title for a message");
        }
    }
}