using AutoMapper;
using ProjectTracker.DataAccess.Repositories;
using ProjectTracker.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;
        private readonly IMapper mapper;

        public ProjectService(IProjectRepository projectRepository, IMapper mapper)
        {
            this.projectRepository = projectRepository;
            this.mapper = mapper;
        }

        public async Task<ProjectListResponse> GetProjectById(int id)
        {
            var project = await projectRepository.GetById(id);
            var result  = mapper.Map<ProjectListResponse>(project);
            return result;

        }

        public async Task<IList<ProjectListResponse>> GetProjects()
        {
            var projects = await projectRepository.GetAll();
            var result = mapper.Map<List<ProjectListResponse>>(projects);
            return result;


        }

        public async Task<IEnumerable< ProjectListResponse>> SearchProjectsByName(string name)
        {
            var projects = await projectRepository.SearchProjectsByName(name);
            var result = mapper.Map<List<ProjectListResponse>>(projects);
            return result;
        }
    }
}
