using Domain.Enums;

namespace Domain.Dtos;

public record MG1InputsDto() : BaseQueueInputsDto
{
    public double StandardDeviationValue { get; set; }
    public TimeUnit StandardDeviationTimeUnit { get; set; }
}
