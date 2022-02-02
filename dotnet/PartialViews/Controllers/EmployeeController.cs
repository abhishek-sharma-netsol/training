using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PartialViews.Models;

namespace PartialViews.Controllers
{
    public class EmployeeController : Controller
    {
      EmployeeViewModel employeeViewModel;
      public EmployeeController(){
          employeeViewModel= new EmployeeViewModel();
          employeeViewModel.Employees.Add(
              new Employee(){
                Id = 1,
                EmployeeName = "User 1",
                EmployeeAge = "21",
                EmployeeGender = Gender.Male 
              });
          employeeViewModel.Employees.Add(
              new Employee(){
                Id = 2,
                EmployeeName = "User 2",
                EmployeeAge = "22",
                EmployeeGender = Gender.Female 
              });
          employeeViewModel.Employees.Add(
              new Employee(){
                Id = 3,
                EmployeeName = "User 3",
                EmployeeAge = "23",
                EmployeeGender = Gender.Male
              });
      }

       public IActionResult Index(int id)
       {
           return View(employeeViewModel.Employees.FirstOrDefault(x => x.Id == id));
       }
      //public IActionResult Index(){
      //  return View();
      //}

        public IActionResult EmployeeList() {

          return View(employeeViewModel);
        }

        public IActionResult AddNewEmployee() {
          return View();
        }
    }
}
