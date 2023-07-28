namespace FinalFede.Controllers.Contracts.Response;

public record MM2Response : BaseQueueMetricResponse
{
    public double SecondServiceValue { get; set; }
    public double Ps { get; set; }
    public double FullServiceValue { get; set; }
}
