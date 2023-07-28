using Domain.Dtos;

namespace Domain.Models.MM2;

public class MM2NoServiceSelection : MM2
{
    public MM2NoServiceSelection(MM2InputsDto inputs) : base(inputs)
    {
    }
    protected override void CalculateMetrics()
    {
        var r = SecondServiceValue / ServiceValue;
        P = 1 - r * (1 + r) / (1 + Math.Pow(r, 2));
        var a = 2 * ServiceValue * SecondServiceValue / (ServiceValue + SecondServiceValue);
        P0 = (1 - P) / (1 - P + (ArriveValue / a));
        Ls = ArriveValue / (1 - P) * (ArriveValue + (1 - P) * a);
        CalculateBaseMM2Metrics();
    }
}
