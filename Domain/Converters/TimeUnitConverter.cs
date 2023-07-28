using Domain.Enums;

namespace Domain.Converters;

public static class TimeUnitConverter
{
    private static Dictionary<TimeUnit, int> _conversionFactors = new()
    {
        { TimeUnit.Seconds, 1 },
        { TimeUnit.Minutes, 60 },
        { TimeUnit.Hours, 3600 }
    };

    public static double ConvertToSeconds(TimeUnit timeUnit, double value)
        => value * _conversionFactors[timeUnit];

    public static double ConvertFromSeconds(TimeUnit timeUnit, double value)
        => value / _conversionFactors[timeUnit];
}
