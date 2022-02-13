using EmployeeLinqTest.Models;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace EmployeeLinqTest.Controllers
{
    public class Employee : Controller
    {
        

        List<EmployeeModel> model = new List<EmployeeModel>()
        {
            new EmployeeModel() { EmpId = 1, EmpName = "RAJAN", EmpAge = 25, EmpEmail = "rajan@gmail.com", EmpFathername = "Rajesh", EmpMothername = "Anjana", EmpSalary = 25000 },
            new EmployeeModel() { EmpId = 2, EmpName = "RAGHU", EmpAge = 23, EmpEmail = "raghu@gmail.com", EmpFathername = "Vijay", EmpMothername = "Kriya", EmpSalary = 28000 },
            new EmployeeModel(){EmpId = 3, EmpName = "MONIKA", EmpAge = 21, EmpEmail = "monika@gmail.com", EmpFathername = "Prakash", EmpMothername = "Sumitra", EmpSalary = 29000},
            new EmployeeModel(){EmpId = 4, EmpName = "PRIYA", EmpAge = 22, EmpEmail = "priya@gmail.com", EmpFathername = "Surinder", EmpMothername = "Kamini", EmpSalary = 35000},
            new EmployeeModel(){EmpId = 5, EmpName = "SOMESH", EmpAge = 28, EmpEmail = "somesh@gmail.com", EmpFathername = "Mohan", EmpMothername = "Divya", EmpSalary = 29000},
            new EmployeeModel(){EmpId = 6, EmpName = "GOURAV", EmpAge = 23, EmpEmail = "gourav@gmail.com", EmpFathername = "Sohan", EmpMothername = "Bharti", EmpSalary = 20000},
            new EmployeeModel(){EmpId = 7, EmpName = "ABHEY", EmpAge = 31, EmpEmail = "abhey@gmail.com", EmpFathername = "Ram", EmpMothername = "Kavya", EmpSalary = 53000},
            new EmployeeModel(){EmpId = 8, EmpName = "SANIA", EmpAge = 30, EmpEmail = "sania@gmail.com", EmpFathername = "Shyam", EmpMothername = "Ginni", EmpSalary = 45000},

        };

        public IActionResult Index()
        {
            return View();
        }

        public  IActionResult AllEmployee()
        {
            var Model = from emp in model
                        select emp;


            return View(Model);
        }

        public  IActionResult EmployeeDetails(int id)
        {
            var Model = model.Where(x => x.EmpId == id).FirstOrDefault(); 
            return View(Model);
        }

    }
}
