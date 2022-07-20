using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace ProjectTracker.API.Filters
{
    public class NumberExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            if (context.Exception is ArgumentOutOfRangeException)
            {
                //Bu filtrenin uygulandığı action'da ArgumentOutOfRangeException meydana gelirse; uygulamanız ne yapacak?
                context.Result = new BadRequestObjectResult(new { message = context.Exception.Message, date=DateTime.Now });
            }
            base.OnException(context);
        }
    }
}
