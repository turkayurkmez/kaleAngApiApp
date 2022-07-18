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

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public Task<IList<ProjectListResponse>> GetProjects()
        {
            var projects = projectRepository.GetAll();
            var result = projects.Result.Select(pr => new ProjectListResponse
            {
                Description = pr.Description,
                Name = pr.Name,
                Id=pr.Id,
                StartedDate = pr.StartedDate
             
            });
            throw new NotImplementedException();
        }
    }
}
