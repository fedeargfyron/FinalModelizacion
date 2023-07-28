using AutoMapper;
using Domain.Dtos;
using Domain.Enums;
using Domain.Models;
using Domain.Models.MM2;
using FinalFede.Controllers.Contracts.Request;
using FinalFede.Controllers.Contracts.Response;

namespace FinalFede.Mappers;

public class MM2Profile : Profile
{
    public MM2Profile()
    {
        CreateMap<MM2Request, MM2InputsDto>()
            .IncludeBase<BaseQueueMetricsRequest, BaseQueueInputsDto>()
            .ForMember(dest => dest.SecondServiceValue, opt => opt.MapFrom(src => Convert.ToDouble(src.SecondServiceValue)))
            .ForMember(dest => dest.SecondServiceTimeUnit, opt => opt.MapFrom(src => Enum.Parse<TimeUnit>(src.SecondServiceTimeUnit)))
            .ForMember(dest => dest.WithServiceSelection, opt => opt.MapFrom(src => src.ServiceSelectionValue));

        CreateMap<MM2, MM2Response>()
            .IncludeBase<BaseQueueMetrics, BaseQueueMetricResponse>();
    }
}
