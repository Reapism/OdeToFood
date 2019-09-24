using OdeToFood.Web.Models;
using System.Configuration;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            GreetingViewModel model = new GreetingViewModel
            {
                Message = name ?? ConfigurationManager.AppSettings["message"]
            };
            return View(model);
        }
    }
}