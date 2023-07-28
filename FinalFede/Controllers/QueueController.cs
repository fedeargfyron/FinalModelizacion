using AutoMapper;
using Domain.Dtos;
using Domain.Interfaces.Services;
using FinalFede.Controllers.Contracts.Request;
using FinalFede.Controllers.Contracts.Response;
using Microsoft.AspNetCore.Mvc;

namespace FinalFede.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QueueController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IQueueService _queueService;
        public QueueController(IMapper mapper, IQueueService queueService)
        {
            _mapper = mapper;
            _queueService = queueService;
        }

        [HttpPost]
        [Route("mm1")]
        public BaseQueueMetricResponse Post([FromBody] BaseQueueMetricsRequest requestValues)
        {
            var inputsDto = _mapper.Map<BaseQueueInputsDto>(requestValues);
            var metrics = _queueService.GetMetrics(inputsDto);
            return _mapper.Map<BaseQueueMetricResponse>(metrics);
        }

        [HttpPost]
        [Route("mm1n")]
        public MM1NResponse Post([FromBody] MM1NRequest requestValues)
        {
            var inputsDto = _mapper.Map<MM1NInputsDto>(requestValues);
            var metrics = _queueService.GetMetrics(inputsDto);
            return _mapper.Map<MM1NResponse>(metrics);
        }

        [HttpPost]
        [Route("mg1")]
        public MG1Response Post([FromBody] MG1Request requestValues)
        {
            var inputsDto = _mapper.Map<MG1InputsDto>(requestValues);
            var metrics = _queueService.GetMetrics(inputsDto);
            return _mapper.Map<MG1Response>(metrics);
        }

        [HttpPost]
        [Route("mm2")]
        public MM2Response Post([FromBody] MM2Request requestValues)
        {
            var inputsDto = _mapper.Map<MM2InputsDto>(requestValues);
            var metrics = _queueService.GetMetrics(inputsDto);
            return _mapper.Map<MM2Response>(metrics);
        }
    }
}
