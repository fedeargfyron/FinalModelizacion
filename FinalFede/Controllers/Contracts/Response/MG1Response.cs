namespace FinalFede.Controllers.Contracts.Response;

public record MG1Response : BaseQueueMetricResponse
{
    public double StandardDeviationValue { get; set; }
}