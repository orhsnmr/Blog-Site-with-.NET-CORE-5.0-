using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace NetCore.Controllers
{
    public class DashboardController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var userName = User.Identity.Name;
            var NS = c.Users.Where(x => x.UserName == userName)
          .Select(y => y.NameSurname).FirstOrDefault();
            ViewBag.v = NS;
            var userMail = c.Users.Where(x => x.UserName == userName)
                .Select(y => y.Email).FirstOrDefault();
            var ID = c.Users.Where(x => x.UserName == userName)
                .Select(y => y.Id).FirstOrDefault();
            ViewBag.v1 = c.blogs.Count().ToString();
            ViewBag.v2 = c.blogs.Where(x => x.WriterID == ID).Count().ToString();
            ViewBag.v3 = c.categories.Count().ToString();
            return View();
        }
    }
}
