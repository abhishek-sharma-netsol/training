using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ViewData.Models;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
          EmployeeBuisnessLayer employeeBL = new EmployeeBuisnessLayer();
          Employee employee = employeeBL.GetEmployeeDetails(102);
          ViewData["Employee"] = employee;
          ViewData["Header"] = "Employee Details";
          return View();
        }

        [Route("Method1")]
        public IActionResult Method1()
        {
          TempData["Name"] = "Pranaya";
          TempData["Age"] = 30;
          TempData.Keep();
          return View();
        }

        [Route("Method2")]
        public IActionResult Method2()
        {
          string Name;
          int Age;
          if(TempData.ContainsKey("Name"))
            Name = TempData["Name"].ToString();
          if(TempData.ContainsKey("Age"))
            Age = int.Parse(TempData["Age"].ToString());

          TempData.Keep("Name");

          return View();
        }

        [Route("Method3")]
        public ActionResult Method3()
        {
          string Name;
          int Age;
          if(TempData.ContainsKey("Name"))
            Name = TempData["Name"].ToString();
          if(TempData.ContainsKey("Age"))
            Age = int.Parse(TempData["Age"].ToString());
          return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
