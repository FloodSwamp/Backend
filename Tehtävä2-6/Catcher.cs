namespace Tehtava2
{
    public class Catcher: ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context) {
            JsonResult error = new JsonResult(context.Exception.Message);
            error.StatusCode = StatusCodes.Status422UnprocessableEntity;

            context.ExceptionHandled = true;
            context.Result = error;
        }
    }
}