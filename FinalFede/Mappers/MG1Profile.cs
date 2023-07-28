using AutoMapper;
using Domain.Dtos;
using Domain.Enums;
using Domain.Models;
using FinalFede.Controllers.Contracts.Request;
using FinalFede.Controllers.Contracts.Response;

namespace FinalFede.Mappers;

public class MG1Profile : Profile
{
    public MG1Profile()
    {
        CreateMap<MG1Request, MG1InputsDto>()
            .IncludeBase<BaseQueueMetricsRequest, BaseQueueInputsDto>()
            .ForMember(dest => dest.StandardDeviationValue, opt => opt.MapFrom(src => Convert.ToDouble(src.StandardDeviationValue)))
            .ForMember(dest => dest.StandardDeviationTimeUnit, opt => opt.MapFrom(src => Enum.Parse<TimeUnit>(src.StandardDeviationTimeUnit)));

        CreateMap<MG1, MG1Response>()
            .IncludeBase<BaseQueueMetrics, BaseQueueMetricResponse>();
    }
}
