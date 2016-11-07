
// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

using Microsoft.AspNetCore.Mvc;

namespace SMART.Home.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            var actionResult = View("Index");
            return actionResult;
        }
    }
}
