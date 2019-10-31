using AutoMapper;
using FewBox.Core.Web.Dto;
using FewBox.Service.Log.Model.Dtos;
using FewBox.Service.Log.Model.Entities;

namespace FewBox.Service.Log.AutoMapperProfiles
{
    public class MapperProfiles : Profile
    {
        public MapperProfiles()
        {
            CreateMap<LogRequestDto, ExceptionLog>();
            CreateMap<ExceptionLog, LogDto>();
            CreateMap<LogRequestDto, TraceLog>();
            CreateMap<TraceLog, LogDto>();
        }
    }
}