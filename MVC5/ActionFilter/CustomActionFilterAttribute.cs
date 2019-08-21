using System;
using System.Diagnostics;
using System.Globalization;
using System.Web.Mvc;

namespace MVC5.ActionFilter
{
    public class CustomActionFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Debug.WriteLine("Action is executing on "+DateTime.Now.ToString(CultureInfo.InvariantCulture));
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Debug.WriteLine("Action has executed on " + DateTime.Now.ToString(CultureInfo.InvariantCulture));
        }
    }
}