using AutoMapper;
using Domain.Dtos;
using Domain.Enums;
using Domain.Models;
using FinalFede.Controllers.Contracts.Request;
using FinalFede.Controllers.Contracts.Response;

namespace FinalFede.Mappers;

public class MM1NProfile : Profile
{
    public MM1NProfile()
    {
        CreateMap<MM1NRequest, MM1NInputsDto>()
            .IncludeBase<BaseQueueMetricsRequest, BaseQueueInputsDto>()
            .ForMember(dest => dest.QueueLengthValue, opt => opt.MapFrom(src => Convert.ToDouble(src.QueueLengthValue)));

        CreateMap<MM1N, MM1NResponse>()
            .IncludeBase<BaseQueueMetrics, BaseQueueMetricResponse>();
    }
}
