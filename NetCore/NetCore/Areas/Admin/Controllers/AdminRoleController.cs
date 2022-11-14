using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Areas.Admin.Models;
using NetCore.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Admin")]
    public class AdminRoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;
        private readonly UserManager<AppUser> _UserManager;

        public AdminRoleController(RoleManager<AppRole> roleManager, UserManager<AppUser> userManager)
        {
            _roleManager = roleManager;
            _UserManager = userManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleModelView p)
        {
            if (ModelState.IsValid)
            {
                AppRole appRole = new AppRole
                {
                    Name = p.Name
                };
                var result = await _roleManager.CreateAsync(appRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(p);
        }

        [HttpGet]
        public IActionResult UpdateRole(int ID)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == ID);
            RoleUpdateViewModel model = new RoleUpdateViewModel
            {
                ID = values.Id,
                name = values.Name
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(RoleUpdateViewModel p)
        {
            var values = _roleManager.Roles.Where(x => x.Id == p.ID).FirstOrDefault();

            values.Name = p.name;
            var result = await _roleManager.UpdateAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }

            return View(p);
        }

        public async Task<IActionResult> DeletRole(int ID)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == ID);
            var result = await _roleManager.DeleteAsync(values);
            if (result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult UserRoleList()
        {
            var values = _UserManager.Users.ToList();
            return View(values);

        }
        [HttpGet]
        public async Task<IActionResult> AssignRole(int ID)
        {
            var user = _UserManager.Users.FirstOrDefault(x => x.Id == ID);
            var roles = _roleManager.Roles.ToList();

            TempData["UserID"] = user.Id;
            var userRole = await _UserManager.GetRolesAsync(user);

            List<RoleAssignViewModel> model = new List<RoleAssignViewModel>();
            foreach (var item in roles)
            {
                RoleAssignViewModel m = new RoleAssignViewModel();
                m.ID = item.Id;
                m.name = item.Name;
                m.Exists = userRole.Contains(item.Name);
                model.Add(m);

            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AssignRole(List<RoleAssignViewModel> model)
        {
            var userID = (int)TempData["UserID"];
            var user = _UserManager.Users.FirstOrDefault(x => x.Id == userID);
            foreach (var item in model)
            {
                if (item.Exists)
                {
                    await _UserManager.AddToRoleAsync(user, item.name);
                }
                else
                {
                    await _UserManager.RemoveFromRoleAsync(user, item.name);
                }
            }
            return RedirectToAction("UserRoleList");
        }
    }
}
