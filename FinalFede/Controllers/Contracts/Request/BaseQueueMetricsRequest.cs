namespace FinalFede.Controllers.Contracts.Request;

public class BaseQueueMetricsRequest
{
    public string ArriveValue { get; set; } = string.Empty;
    public string ArriveTimeUnit { get; set; } = string.Empty;
    public string ServiceValue { get; set; } = string.Empty;
    public string ServiceTimeUnit { get; set; } = string.Empty;
    public string NUnitsValue { get; set; } = string.Empty;
}
