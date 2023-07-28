using Domain.Dtos;

namespace Domain.Models.MM2;

public class MM2 : BaseQueueMetrics
{
    public double SecondServiceValue { get; set; }
    public double FullServiceValue { get; set; }

    public MM2(MM2InputsDto inputs) : base(inputs)
    {
        SecondServiceValue = ConvertValueWithTimeUnit(inputs.SecondServiceTimeUnit, TimeUnit, inputs.SecondServiceValue);
        FullServiceValue = ServiceValue + SecondServiceValue;
        CalculateMetrics();
    }

    protected override void CalculateMetrics()
    {
        P = CalculateP();
        P0 = CalculateP0();
        Ls = P / P0;
        CalculateBaseMM2Metrics();
    }
    protected void CalculateBaseMM2Metrics()
    {
        Pn = CalculatePn();
        Ws = Ls / ArriveValue;
        Lq = Math.Pow(P, 2) / P0;
        Wq = Lq / ArriveValue;
    }
    protected override double CalculateP() => ArriveValue / FullServiceValue;
}
