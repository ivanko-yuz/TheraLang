using Microsoft.AspNetCore.Mvc;

namespace TheraLang.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Routing() // Routing  
        {
            return View();
        }
    }
}