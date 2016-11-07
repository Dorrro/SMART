using Microsoft.AspNetCore.Mvc;

namespace SMART.Home.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
