using Microsoft.AspNetCore.Mvc;
using FirstCoreWebApplication.Models;
using System.Linq;

namespace FirstCoreWebApplication.Controllers {

  public class EmployeeController : Controller {
    EmployeeViewModel employeeViewModel;
    public EmployeeController() {
      employeeViewModel = new EmployeeViewModel();
      employeeViewModel.Employees.Add(
          new Employee(){
            EmployeeId = 1,
            EmployeeName = "Abhishek",
            EmployeeDob = "24-03-1997",
            EmployeeSalary = "15000"
          });

      employeeViewModel.Employees.Add(
          new Employee() {
            EmployeeId = 2,
            EmployeeName = "Ajay",
            EmployeeDob = "14-11-1996",
            EmployeeSalary = "15000"
          });

      employeeViewModel.Employees.Add(
          new Employee() {
            EmployeeId = 3,
            EmployeeName = "Munish",
            EmployeeDob = "21-09-1997",
            EmployeeSalary = "19000"
          });
      employeeViewModel.Employees.Add(new Employee()
        {
          EmployeeId = 4,
          EmployeeName = "Sahil",
          EmployeeDob = "01-06-1995",
          EmployeeSalary = "17000"
        });

       employeeViewModel.Employees.Add(new Employee()
       {
           EmployeeId = 5,
           EmployeeName = "Kuldeep",
           EmployeeDob = "24-08-1997",
           EmployeeSalary = "14000"
       });
    }

    public IActionResult Index(int id){
      return View(employeeViewModel.Employees.FirstOrDefault(x => x.EmployeeId == id));
    }

    public IActionResult EmployeeList(){
      return View(employeeViewModel);
    }
  }
} 
