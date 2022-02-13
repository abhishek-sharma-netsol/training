using NS.EMS.Buisness;
using NS.EMS.Model;
using Microsoft.AspNetCore.Mvc;

namespace NS.EMS.WEB.Controllers{

  public class EmployeeController: Controller
  {
    private readonly IEmployeeBuisness  _IEmployeeBuisness;

    public EmployeeController(IEmployeeBuisness IEmployeeBuisness)
    {
      _IEmployeeBuisness = IEmployeeBuisness;
    }

    public IActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public IActionResult Create(EmployeeModel employeeModel)
    {
      _IEmployeeBuisness.AddEmployee(employeeModel);
      return View();
    }
  }
}
