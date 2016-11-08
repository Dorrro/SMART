using Microsoft.AspNetCore.Mvc;

namespace SMART.Sites.Home.Controllers
{
    public class HomeController : Controller
    {
        // GET: /Home/
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}