using Microsoft.AspNetCore.Mvc;

namespace NetCore.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
