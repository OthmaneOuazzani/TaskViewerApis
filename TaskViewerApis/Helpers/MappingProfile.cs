using AutoMapper;
using TaskViewerApis.Models;

namespace TaskViewerApis.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Error, Error>();
            CreateMap<TaskViewer.Models.User, TaskViewer.Models.User>();
        }
    }
}
