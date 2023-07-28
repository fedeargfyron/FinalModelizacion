using Domain.Dtos;
using Domain.Models;
using Domain.Models.MM2;

namespace Domain.Helpers;

public static class MM2Helper
{
    public static MM2 GetMM2(MM2InputsDto inputsDto)
    {
        var convertedSecondServiceValue = BaseQueueMetrics.ConvertValueWithTimeUnit(
            inputsDto.SecondServiceTimeUnit,
            inputsDto.ServiceTimeUnit,
            inputsDto.SecondServiceValue);

        if(convertedSecondServiceValue == inputsDto.ServiceValue)
        {
            return new (inputsDto);
        }

        if (inputsDto.WithServiceSelection)
        {
            return new MM2ServiceSelection(inputsDto);
        }

        return new MM2NoServiceSelection(inputsDto);
    }
}
