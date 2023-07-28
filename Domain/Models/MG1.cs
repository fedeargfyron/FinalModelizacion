using Domain.Dtos;

namespace Domain.Models;

public class MG1 : BaseQueueMetrics
{
    public double StandardDeviationValue { get; set; }
    public MG1(MG1InputsDto inputs) : base(inputs)
    {
        StandardDeviationValue = ConvertValueWithTimeUnit(inputs.StandardDeviationTimeUnit, TimeUnit, inputs.StandardDeviationValue);
        CalculateMetrics();
    }

    protected override void CalculateMetrics()
    {
        P = CalculateP();
        P0 = CalculateP0();
        Pn = CalculatePn();
        Lq = (Math.Pow(ArriveValue, 2) * Math.Pow(StandardDeviationValue, 2) + Math.Pow(P, 2)) / (2 * P0);
        Ls = P + Lq;
        Wq = Lq / ArriveValue;
        Ws = Wq + StandardDeviationValue;
    }
}
