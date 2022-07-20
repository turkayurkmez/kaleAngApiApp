using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProjectTracker.Business;

namespace ProjectTracker.API.Filters
{
    public class ItemExistsFilter : IAsyncActionFilter
    {
        private readonly IProjectService projectService;

        public ItemExistsFilter(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            //1. Bu filtrenin kullanıldığı action'da id parametresi var mı?
            if (!context.ActionArguments.ContainsKey("id"))
            {
                context.Result = new BadRequestResult();
                return;
            }

            //2. id değeri int mi?
            if (!(context.ActionArguments["id"] is int id))
            {
                context.Result = new BadRequestResult();
                return;
            }

            var isExists = await projectService.IsExists(id);
            if (!isExists)
            {
                context.Result = new NotFoundObjectResult(new { message = $"{id} id'li bir proje yok!" });
                return;
            }

            await next();

        }
    }
}
