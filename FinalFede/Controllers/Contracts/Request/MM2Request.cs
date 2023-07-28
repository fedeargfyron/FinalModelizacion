namespace FinalFede.Controllers.Contracts.Request;

public class MM2Request : BaseQueueMetricsRequest
{
    public string SecondServiceValue { get; set; } = string.Empty;
    public string SecondServiceTimeUnit { get; set; } = string.Empty;
    public bool ServiceSelectionValue { get; set; }
}