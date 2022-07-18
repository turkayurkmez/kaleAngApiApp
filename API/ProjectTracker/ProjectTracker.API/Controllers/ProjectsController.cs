using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProjectTracker.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        /*
         * Http verbs:
         * GET, POST, PUT, DELETE
         * 
         */
        [HttpGet]
        public IActionResult GetProjects()
        {
            string[] projectNames = { "X", "Y", "Z" };
            return Ok(projectNames);
        }
    }
}
