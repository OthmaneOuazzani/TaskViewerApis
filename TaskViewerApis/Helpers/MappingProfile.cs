using AutoMapper;
using TaskViewerApis.Dtos;
using TaskViewerApis.Models;

namespace TaskViewerApis.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Error, Error>();
        }
    }
}
