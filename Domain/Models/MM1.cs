using Domain.Dtos;

namespace Domain.Models;

public class MM1 : BaseQueueMetrics
{
    public MM1(BaseQueueInputsDto inputs) : base(inputs)
    {
        CalculateMetrics();
    }

    protected override void CalculateMetrics()
    {
        P = CalculateP();
        P0 = CalculateP0();
        Pn = CalculatePn();
        var serviceMinusArrive = ServiceValue - ArriveValue;
        Ls = ArriveValue / serviceMinusArrive;
        Lq = Math.Pow(ArriveValue, 2) / (ServiceValue * serviceMinusArrive);
        Ws = 1 / serviceMinusArrive;
        Wq = ArriveValue / ServiceValue * serviceMinusArrive;
    }
}
