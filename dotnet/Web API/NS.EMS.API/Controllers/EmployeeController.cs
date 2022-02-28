using NS.EMS.API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace NS.EMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    [Authorize]
    public class EmployeeController: Controller
    {
      [HttpGet]
      public IActionResult GetEmployees()
      {
        var employeeList = new List<Employee>();
        using (var context = new EmployeeDbContext())
        {
          employeeList = context.Employees.ToList();
        }
        
        return Ok(employeeList); 
      }

      [HttpGet]
      public IActionResult GetEmployeeById(int id)
      {
        var employeeList = new List<Employee>();
        using (var context = new EmployeeDbContext())
        {
          employeeList = context.Employees.Where(x => x.Id == id).ToList();
        }
        
        return Ok(employeeList); 
      }

      [HttpPost]
      public IActionResult AddEmployee(Employee employee)
      {
        using (var context = new EmployeeDbContext())
        {
          context.Employees.Add(employee);
          context.SaveChanges();
        }
        
        return Ok("Record Inserted Successfully"); 
      }

      [HttpPut]
      public IActionResult UpdateEmployee(Employee employee)
      {
        using (var context = new EmployeeDbContext())
        {
          context.Employees.Update(employee);
          context.SaveChanges();
        }
        
        return Ok("Record Updated Successfully"); 
      }


    }
}
