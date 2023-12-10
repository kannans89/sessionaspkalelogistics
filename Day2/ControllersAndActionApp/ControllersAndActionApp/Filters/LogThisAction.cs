using Microsoft.AspNetCore.Mvc.Filters;

namespace ControllersAndActionApp.Filters
{
    public class LogThisAction:ActionFilterAttribute
    {
        private string _controllerName;
        private string _actionName;
        public override void OnActionExecuting(ActionExecutingContext context)
        {
          _controllerName=  context.RouteData.Values["controller"].ToString();
         _actionName= context.RouteData.Values["action"].ToString();
            Console.WriteLine($"Beofre exeuction of {_actionName} of {_controllerName}");
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine($"After exeuction of {_actionName} of {_controllerName}");
        }
    }
}
