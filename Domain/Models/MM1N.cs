using Domain.Dtos;

namespace Domain.Models;

public class MM1N : BaseQueueMetrics
{
    public double QueueLengthValue { get; set; }
    public double Pb { get; set; }
    public double Lb { get; set; }
    public double Wb { get; set; }
    public double EfectiveArriveValue { get; set; }
    public double OutputPerformance { get; set; }

    public MM1N(MM1NInputsDto inputs) : base(inputs)
    {
        QueueLengthValue = inputs.QueueLengthValue;
        CalculateMetrics();
    }

    protected override void CalculateMetrics()
    {
        P = CalculateP();
        Pn = CalculatePn();

        var powOfPWithQueueLengthPlusOne = Math.Pow(P, QueueLengthValue + 1);
        var powOfPWithQueueLength = Math.Pow(P, QueueLengthValue);
        P0 = (1 - P) / (1 - powOfPWithQueueLengthPlusOne);
        Pb = powOfPWithQueueLength * (1 - P) / (1 - powOfPWithQueueLengthPlusOne);
        EfectiveArriveValue = ArriveValue * (1 - Pb);
        OutputPerformance = ServiceValue * (1 - P0);
        Ls = (P / (1 - P)) - (QueueLengthValue - 1) * powOfPWithQueueLengthPlusOne / (1 - powOfPWithQueueLengthPlusOne);
        Lq = Ls - (1 - powOfPWithQueueLength) * P / (1 - powOfPWithQueueLengthPlusOne);
        Lb = Lq / (1 - P0);
        Wq = Lq / EfectiveArriveValue;
        Ws = Wq + (1 / ServiceValue);
        Wb = Wq / (1 - P0);
    }
}
