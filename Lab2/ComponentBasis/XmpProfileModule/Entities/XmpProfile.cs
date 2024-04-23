using System;
using System.Text.RegularExpressions;

namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.XmpProfileModule.Entities;

public class XmpProfile
{
    private const string TimingsPattern = @"^\d+-\d+-\d+-\d+$";
    private static readonly Regex TimingsRegex = new Regex(TimingsPattern, RegexOptions.Compiled);

    public XmpProfile(
        string timings,
        double voltageInV,
        double frequencyInMhz)
    {
        if (!IsValidTimingsFormat(timings))
        {
            throw new ArgumentException("Unacceptable timings", nameof(timings));
        }

        Timings = timings;
        VoltageInV = voltageInV;
        FrequencyInMhz = frequencyInMhz;
    }

    public string Timings { get; }
    public double VoltageInV { get; }
    public double FrequencyInMhz { get; }
    public static bool IsValidTimingsFormat(string timings)
    {
        return TimingsRegex.IsMatch(timings);
    }
}