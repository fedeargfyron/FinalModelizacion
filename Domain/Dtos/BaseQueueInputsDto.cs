using Domain.Enums;

namespace Domain.Dtos;

public record BaseQueueInputsDto
{
    public double ArriveValue { get; set; }
    public double ServiceValue { get; set; }
    public TimeUnit ArriveTimeUnit { get; set; }
    public TimeUnit ServiceTimeUnit { get; set; }
    public int NUnits { get; set; }
}
