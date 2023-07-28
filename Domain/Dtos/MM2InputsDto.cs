using Domain.Enums;

namespace Domain.Dtos;

public record MM2InputsDto() : BaseQueueInputsDto
{
    public double SecondServiceValue { get; set; }
    public TimeUnit SecondServiceTimeUnit { get; set; }
    public bool WithServiceSelection { get; set; }
}
