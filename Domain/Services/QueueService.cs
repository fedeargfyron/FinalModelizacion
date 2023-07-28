using Domain.Dtos;
using Domain.Helpers;
using Domain.Interfaces.Services;
using Domain.Models;
using Domain.Models.MM2;

namespace Domain.Services;

public class QueueService : IQueueService
{
    public MM1 GetMetrics(BaseQueueInputsDto inputsDto)
        => new (inputsDto);

    public MM1N GetMetrics(MM1NInputsDto inputsDto)
        => new(inputsDto);

    public MM2 GetMetrics(MM2InputsDto inputsDto)
        => MM2Helper.GetMM2(inputsDto);

    public MG1 GetMetrics(MG1InputsDto inputsDto)
        => new(inputsDto);
}
