using BloApiDemo.DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace BloApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {
        [HttpGet]
        public IActionResult EmployeeList()
        {
            using var c = new Context();
            var values = c.employees.ToList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult EmployeeAdd(Employee employee)
        {
            using var c = new Context();
            c.Add(employee);
            c.SaveChanges();
            return Ok();
        }

        [HttpGet("{ID}")]
        public IActionResult EmployeeGet(int ID)
        {
            using var c = new Context();
            var employe = c.employees.Find(ID);
            if (employe == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(employe);
            }
        }

        [HttpDelete("{ID}")]
        public IActionResult EmployeeDelete(int ID)
        {
            using var c = new Context();
            var employe = c.employees.Find(ID);            
            if (employe == null)
            {
                return NotFound();
            }
            else
            {
                c.Remove(employe);
                c.SaveChanges();
                return Ok();
            }

        }

        [HttpPut]
        public IActionResult EmployeeUpdate(Employee employee)
        {
            using var c = new Context();
            var emp = c.Find<Employee>(employee.ID);
            if (emp == null)
            {
                return NotFound();
            }
            else
            {
                emp.Name = employee.Name;
                c.Update(emp);
                c.SaveChanges();
                return Ok();
            }
        }
    }
}
