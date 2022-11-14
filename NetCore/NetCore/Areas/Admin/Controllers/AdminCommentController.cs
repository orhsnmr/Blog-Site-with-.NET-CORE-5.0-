using BloApiDemo.DataAccessLayer;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());

        Context c = new Context();
        public IActionResult Index()
        {
            var values = cm.GetCommetnWithBlog();
            return View(values);
        }

        public IActionResult DeleteComment(int ID)
        {
            var dc = cm.GetByID(ID);
            cm.TDelete(dc);
            return RedirectToAction("Index", "AdminComment");  
        }

        [HttpGet]
        public IActionResult EditComment()
        {
         return View();
        }

        [HttpPost]
        public  IActionResult EditComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;            
            cm.CommentAdd(p);
            return RedirectToAction("/Admin/AdminComment");
        }


    }
}
