namespace FinalFede.Controllers.Contracts.Response;

public record MM1NResponse : BaseQueueMetricResponse
{
    public double QueueLengthValue { get; set; }
    public double Wb { get; set; }
    public double Lb { get; set; }
    public double EfectiveArriveValue { get; set; }
    public double OutputPerformance { get; set; }
    public double Pb { get; set; }
}
