namespace Itmo.ObjectOrientedProgramming.Lab2.ComponentBasis.RamModule.Models;

public class JedecFrequencyAndVoltageStandard
{
    public JedecFrequencyAndVoltageStandard(
        double jedecFrequency,
        double jedecVoltage)
    {
        Frequency = jedecFrequency;
        Voltage = jedecVoltage;
    }

    public double Frequency { get; }
    public double Voltage { get; }
}