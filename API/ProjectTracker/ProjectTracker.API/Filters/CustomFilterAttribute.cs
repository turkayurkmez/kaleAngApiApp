using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjectTracker.API.Filters
{
    public class CustomFilterAttribute : ActionFilterAttribute
    {
        public override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            return base.OnActionExecutionAsync(context, next);
        }
    }
}
