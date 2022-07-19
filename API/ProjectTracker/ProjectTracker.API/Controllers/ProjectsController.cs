using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectTracker.Business;
using ProjectTracker.Dtos.Requests;
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

        [HttpPost]
        public async Task<IActionResult> AddProject(CreateProjectRequest createProjectRequest)
        {
            if (ModelState.IsValid)
            {
                ProjectListResponse createdProject = await projectService.AddProject(createProjectRequest);
                return CreatedAtAction(nameof(GetProjectsById), routeValues: new { id = createdProject.Id }, createdProject);
            }

            return BadRequest(ModelState);
          
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProject(int id, UpdateProjectRequest updateProjectRequest)
        {
            bool isProjectExists = await projectService.IsExists(id);
            if (isProjectExists)
            {
                if (ModelState.IsValid)
                {
                    //idempotent
                    // TODO: ProjectService, Mapping ve Repository işlemleri yapılacak!
                }

                return BadRequest(ModelState);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool isProjectExists = await projectService.IsExists(id);
            if (isProjectExists)
            {

            }
            return NotFound();
        } 

    }
}
