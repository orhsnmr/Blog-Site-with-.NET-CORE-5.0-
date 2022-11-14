using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace NetCore.Controllers
{
	public class AboutController : Controller
	{
		AboutManager cm = new AboutManager(new EfAboutRepository());
		public IActionResult Index()
		{
            var values = cm.GetList();
            return View(values);
		}

		public PartialViewResult SocialMediaAbout()
		{
			return PartialView();
		}
	}
}
