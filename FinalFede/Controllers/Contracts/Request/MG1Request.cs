namespace FinalFede.Controllers.Contracts.Request;

public class MG1Request : BaseQueueMetricsRequest
{
    public string StandardDeviationValue { get; set; } = string.Empty;
    public string StandardDeviationTimeUnit { get; set; } = string.Empty;
}