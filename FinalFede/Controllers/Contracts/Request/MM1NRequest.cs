namespace FinalFede.Controllers.Contracts.Request;

public class MM1NRequest : BaseQueueMetricsRequest
{
    public string QueueLengthValue { get; set; } = string.Empty;
}