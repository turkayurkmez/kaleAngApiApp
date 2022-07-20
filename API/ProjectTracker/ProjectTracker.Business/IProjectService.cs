using ProjectTracker.Domain;
using ProjectTracker.Dtos.Requests;
using ProjectTracker.Dtos.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.Business
{
    public interface IProjectService
    {
        Task<IList<ProjectListResponse>> GetProjects();
        Task<ProjectListResponse> GetProjectById(int id);
        Task<IEnumerable<ProjectListResponse>> SearchProjectsByName(string name);
        Task<ProjectListResponse> AddProject(CreateProjectRequest createProjectRequest);
        Task<bool> IsExists(int id);

        Task UpdateProject(UpdateProjectRequest updateProjectRequest); 
        Task DeleteProject(int id);

    }
}
