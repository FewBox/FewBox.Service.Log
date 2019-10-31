using AutoMapper;
using FewBox.Service.Log.Model.Entities;
using FewBox.Service.Log.Model.Dtos;
using FewBox.Service.Log.Model.Repositories;
using FewBox.Core.Web.Controller;
using FewBox.Core.Web.Dto;
using FewBox.Core.Web.Filter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;

namespace FewBox.Service.Log.Controllers
{
    [Route("api/[controller]")]
    public class LogsController : MapperController
    {
        private IExceptionLogRepository ExceptionLogRepository { get; set; }
        private ITraceLogRepository TraceLogRepository { get; set; }

        public LogsController(IExceptionLogRepository exceptionLogRepository, ITraceLogRepository traceLogRepository, IMapper mapper) : base(mapper)
        {
            this.ExceptionLogRepository = exceptionLogRepository;
            this.TraceLogRepository = traceLogRepository;
        }

        [HttpGet]
        public PayloadResponseDto<IEnumerable<LogDto>> Get([FromQuery] LogTypeDto logTypeDto)
        {
            if (logTypeDto == LogTypeDto.Exception)
            {
                return new PayloadResponseDto<IEnumerable<LogDto>>
                {
                    Payload = this.Mapper.Map<IEnumerable<ExceptionLog>, IEnumerable<LogDto>>(this.ExceptionLogRepository.FindAll())
                };
            }
            else
            {
                return new PayloadResponseDto<IEnumerable<LogDto>>
                {
                    Payload = this.Mapper.Map<IEnumerable<TraceLog>, IEnumerable<LogDto>>(this.TraceLogRepository.FindAll())
                };
            }
        }

        [HttpGet("paging")]
        public PayloadResponseDto<PagingDto<LogDto>> Get([FromQuery] LogTypeDto logTypeDto, int pageIndex = 1, int pageRange = 5)
        {
            if (logTypeDto == LogTypeDto.Exception)
            {
                return new PayloadResponseDto<PagingDto<LogDto>>
                {
                    Payload = new PagingDto<LogDto>
                    {
                        Items = this.Mapper.Map<IEnumerable<ExceptionLog>, IEnumerable<LogDto>>(this.ExceptionLogRepository.FindAll(pageIndex, pageRange)),
                        PagingCount = (int)Math.Ceiling((double)this.ExceptionLogRepository.Count() / pageRange)
                    }
                };
            }
            else
            {
                return new PayloadResponseDto<PagingDto<LogDto>>
                {
                    Payload = new PagingDto<LogDto>
                    {
                        Items = this.Mapper.Map<IEnumerable<TraceLog>, IEnumerable<LogDto>>(this.TraceLogRepository.FindAll(pageIndex, pageRange)),
                        PagingCount = (int)Math.Ceiling((double)this.TraceLogRepository.Count() / pageRange)
                    }
                };
            }
        }

        [HttpGet("{id}")]
        public PayloadResponseDto<LogDto> Get(Guid id, [FromQuery] LogTypeDto logTypeDto)
        {
            if (logTypeDto == LogTypeDto.Exception)
            {
                return new PayloadResponseDto<LogDto>
                {
                    Payload = this.Mapper.Map<ExceptionLog, LogDto>(this.ExceptionLogRepository.FindOne(id))
                };
            }
            else
            {
                return new PayloadResponseDto<LogDto>
                {
                    Payload = this.Mapper.Map<TraceLog, LogDto>(this.TraceLogRepository.FindOne(id))
                };
            }
        }

        [HttpPost]
        [Transaction]
        public LogResponseDto Post([FromBody]LogRequestDto logRequest)
        {
            Guid logId;
            if (logRequest.Type == LogTypeDto.Exception)
            {
                var log = this.Mapper.Map<LogRequestDto, ExceptionLog>(logRequest);
                logId = this.ExceptionLogRepository.Save(log);
            }
            else
            {
                var log = this.Mapper.Map<LogRequestDto, TraceLog>(logRequest);
                logId = this.TraceLogRepository.Save(log);
            }
            return new LogResponseDto
            {
            };
        }

        [HttpDelete("{id}")]
        [Transaction]
        public PayloadResponseDto<int> Delete(Guid id, [FromQuery] LogTypeDto logTypeDto)
        {
            if (logTypeDto == LogTypeDto.Exception)
            {
                return new PayloadResponseDto<int>
                {
                    Payload = this.ExceptionLogRepository.Recycle(id)
                };
            }
            else
            {
                return new PayloadResponseDto<int>
                {
                    Payload = this.TraceLogRepository.Recycle(id)
                };
            }
        }
    }
}
