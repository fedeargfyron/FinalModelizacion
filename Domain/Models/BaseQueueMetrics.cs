using Domain.Converters;
using Domain.Dtos;
using Domain.Enums;
using System.Reflection.Metadata.Ecma335;

namespace Domain.Models;

public abstract class BaseQueueMetrics
{
    public TimeUnit TimeUnit { get; set; }
    public double ArriveValue { get; set; }
    public double ServiceValue { get; set; }
    public int NUnits { get; set; }
    public double Ls { get; set; }
    public double Lq { get; set; }
    public double Ws { get; set; }
    public double Wq { get; set; }
    public double P { get; set; }
    public double P0 { get; set; }
    public double Pn { get; set; }
    protected BaseQueueMetrics(BaseQueueInputsDto inputs)
    {
        SetInitialMetrics(inputs);
    }
    protected abstract void CalculateMetrics();

    protected virtual double CalculateP() 
        => ArriveValue / ServiceValue;

    protected double CalculateP0() 
        => 1 - P;

    protected double CalculatePn() 
        => NUnits == 0 ? 0 : (1 - P) * Math.Pow(P, NUnits);

    private void SetInitialMetrics(BaseQueueInputsDto inputs)
    {
        TimeUnit = inputs.ArriveTimeUnit;
        ArriveValue = inputs.ArriveValue;
        NUnits = inputs.NUnits;
        ServiceValue = ConvertValueWithTimeUnit(inputs.ServiceTimeUnit, TimeUnit, inputs.ServiceValue);
    }

    public static double ConvertValueWithTimeUnit(TimeUnit sourceTimeUnit, TimeUnit destinationTimeUnit, double value)
    {
        var secondsValue = TimeUnitConverter.ConvertToSeconds(sourceTimeUnit, value);
        return TimeUnitConverter.ConvertFromSeconds(destinationTimeUnit, secondsValue);
    }
}
