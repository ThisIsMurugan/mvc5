using System.Web.Mvc;
using MVC5.ModelBinder;
using MVC5.Models;

namespace MVC5.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index([ModelBinder(typeof(CustomerModelBinder))]
                                    Customer objCustomer)
        {
            return View("displayCustomer",objCustomer);
        }
    }
}