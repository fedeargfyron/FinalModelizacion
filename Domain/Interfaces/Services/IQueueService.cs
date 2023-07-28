using Domain.Dtos;
using Domain.Models;
using Domain.Models.MM2;

namespace Domain.Interfaces.Services;

public interface IQueueService
{
    MM1 GetMetrics(BaseQueueInputsDto inputsDto);
    MM1N GetMetrics(MM1NInputsDto inputsDto);
    MM2 GetMetrics(MM2InputsDto inputsDto);
    MG1 GetMetrics(MG1InputsDto inputsDto);
}
