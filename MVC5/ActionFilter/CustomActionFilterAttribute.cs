using System;
using System.Globalization;
using System.Web.Mvc;
using MVC5.Logger;

namespace MVC5.ActionFilter
{
    public class CustomActionFilterAttribute:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log.Instance.Debug("Action is executing on "+DateTime.Now.ToString(CultureInfo.InvariantCulture)+" "+filterContext.ActionDescriptor);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log.Instance.Debug("Action has executed on " + DateTime.Now.ToString(CultureInfo.InvariantCulture));
        }
    }
}