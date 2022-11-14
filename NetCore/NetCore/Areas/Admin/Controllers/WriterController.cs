using Microsoft.AspNetCore.Mvc;
using NetCore.Areas.Admin.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;

namespace NetCore.Areas.Admin.Controllers
{
    public class WriterController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriter = JsonConvert.SerializeObject(writers);
            return Json(jsonWriter);
        }

        public IActionResult GetWriterByID(int writerID)
        {
            var findwriter = writers.FirstOrDefault(x => x.id == writerID);
            var jsonWriter = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriter);
        }

        [HttpPost]
        public IActionResult AddWriter(WriterClass w)
        {
            writers.Add(w);
            var JsonWriters = JsonConvert.SerializeObject(w);
            return Json(JsonWriters);
        }
        public IActionResult DeleteWriter(int ID)
        {
            var writer = writers.FirstOrDefault(x => x.id == ID);
            writers.Remove(writer);
            return Json(writer);
        }

        public IActionResult UpdateWriter(WriterClass wc)
        {
            var writer = writers.FirstOrDefault(x => x.id == wc.id);
            writer.name = wc.name;
            var JsonWriter = JsonConvert.SerializeObject(writer);
            return Json(JsonWriter);
        }
        public static List<WriterClass> writers = new List<WriterClass>
        {
            new WriterClass
                {
                     id = 1,
                        name="Orhan"
                },
            new WriterClass
                {
                        id = 2,
                    name="Halil"
                 },
            new WriterClass
                {
                    id = 3,
                    name="Buse"
                 }
        };
    }
}
