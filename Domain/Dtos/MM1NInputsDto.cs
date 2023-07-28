namespace Domain.Dtos;

public record MM1NInputsDto() : BaseQueueInputsDto
{
    public double QueueLengthValue { get; set; }
}
