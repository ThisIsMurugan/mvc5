using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5.ActionFilter;

namespace MVC5.Controllers
{
    [CustomActionFilter]
    public class ActionFilterDemoController : Controller
    {
        // GET: ActionFilterDemo
        public ActionResult Index()
        {
            return View();
        }
    }
}