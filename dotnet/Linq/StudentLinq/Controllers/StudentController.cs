using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentLinq.Models;

namespace StudentLinq.Controllers
{
    public class StudentController : Controller
    {
      List<Student> studentList = new List<Student>() 
      {
        new Student() { Id = 1, Name = "Student1", Age = 21, FatherName = "FatherOf1", MotherName = "MotherOf1" },
        new Student() { Id = 2, Name = "Student2", Age = 22, FatherName = "FatherOf2", MotherName = "MotherOf2" },
        new Student() { Id = 3, Name = "Student3", Age = 23, FatherName = "FatherOf3", MotherName = "MotherOf3" },
        new Student() { Id = 4, Name = "Student4", Age = 24, FatherName = "FatherOf4", MotherName = "MotherOf4" },
        new Student() { Id = 5, Name = "Student5", Age = 25, FatherName = "FatherOf5", MotherName = "MotherOf5" },

      };

      public IActionResult Index()
      {
        var result = from std in studentList
                     select std;
          return View(result);
      }

      public IActionResult Details(int id) {
        var result = studentList.Where(x => x.Id == id).FirstOrDefault(); 
        return View(result);
      }
    }
}
