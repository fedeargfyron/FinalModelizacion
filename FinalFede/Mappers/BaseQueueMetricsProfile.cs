using AutoMapper;
using Domain.Dtos;
using Domain.Enums;
using Domain.Models;
using FinalFede.Controllers.Contracts.Request;
using FinalFede.Controllers.Contracts.Response;

namespace FinalFede.Mappers;

public class BaseQueueMetricsProfile : Profile
{
    public BaseQueueMetricsProfile()
    {
        CreateMap<BaseQueueMetricsRequest, BaseQueueInputsDto>()
            .ForMember(dest => dest.ArriveValue, opt => opt.MapFrom(src => Convert.ToDouble(src.ArriveValue)))
            .ForMember(dest => dest.ServiceValue, opt => opt.MapFrom(src => Convert.ToDouble(src.ServiceValue)))
            .ForMember(dest => dest.ArriveTimeUnit , opt => opt.MapFrom(src => Enum.Parse<TimeUnit>(src.ArriveTimeUnit)))
            .ForMember(dest => dest.ServiceTimeUnit , opt => opt.MapFrom(src => Enum.Parse<TimeUnit>(src.ServiceTimeUnit)))
            .ForMember(dest => dest.NUnits, opt => opt.MapFrom(src => string.IsNullOrEmpty(src.NUnitsValue) ? 0 : Convert.ToInt32(src.NUnitsValue)));

        CreateMap<BaseQueueMetrics, BaseQueueMetricResponse>()
            .ForMember(dest => dest.TimeUnit, opt => opt.MapFrom(src => Convert.ToString(src.TimeUnit)));
    }
}
