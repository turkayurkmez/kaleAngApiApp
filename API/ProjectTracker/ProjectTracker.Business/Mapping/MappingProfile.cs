using AutoMapper;
using ProjectTracker.Domain;
using ProjectTracker.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Task, ProjectTaskListResponse>();
            CreateMap<Project, ProjectListResponse>();
           
        }
    }
}
