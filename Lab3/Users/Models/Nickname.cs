using System;
using System.Text.RegularExpressions;

namespace Itmo.ObjectOrientedProgramming.Lab3.Users.Models;

public class Nickname
{
    private const string NicknamePattern = @"^[A-Za-z]+\d+[!@#$%^&]$";
    private static readonly Regex NicknameRegex = new Regex(NicknamePattern, RegexOptions.Compiled);

    public Nickname(string userName)
    {
        ValidateNickname(userName);
        Name = userName;
    }

    public string Name { get; }

    public static void ValidateNickname(string userName)
    {
        if (!NicknameRegex.IsMatch(userName))
        {
            throw new ArgumentException("Invalid nickname to use");
        }
    }
}