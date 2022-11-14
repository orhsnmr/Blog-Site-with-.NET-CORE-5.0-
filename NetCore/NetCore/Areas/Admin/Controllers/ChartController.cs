using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.AspNetCore.Mvc;
using NetCore.Areas.Admin.Models;
using System.Collections.Generic;

namespace NetCore.Areas.Admin.Controllers
{
    public class ChartController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass
            {
                categoryname = "Teknoloji",
                categorycount=10 
            }); list.Add(new CategoryClass
            {
                categoryname = "Yazılım",
                categorycount = 14
            }); list.Add(new CategoryClass
            {
                categoryname = "Spor",
                categorycount = 5
            });
            return Json(new { jsonList = list });
        }
    }
}
