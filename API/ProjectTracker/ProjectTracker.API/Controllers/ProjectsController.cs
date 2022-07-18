using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Business;
using ProjectTracker.Dtos.Responses;

namespace ProjectTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private IProjectService projectService;

        public ProjectsController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        /*
         * Http verbs:
         * GET, POST, PUT, DELETE
         * 
         */
        [HttpGet]
        public async Task<IActionResult> GetProjects()
        {
            var projects = await projectService.GetProjects();
            return Ok(projects);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProjectsById(int id)
        {
            ProjectListResponse project = await projectService.GetProjectById(id);
            if (project != null)
            {
                return Ok(project);
            }
            return NotFound();
        }

        [HttpGet("[action]/{name}")]
        public async Task<IActionResult> SearchProject(string name)
        {
            var projects = await projectService.SearchProjectsByName(name);
            return Ok(projects); 
        }

    }
}
