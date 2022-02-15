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
      var personsList = _IEmployeeBuisness.Details();
      return View(personsList);
    }

        [HttpGet]
        public IActionResult Create() => View();

        [HttpPost]
    public IActionResult Create(EmployeeModel employeeModel)
    {
      var res = _IEmployeeBuisness.AddEmployee(employeeModel);
      return View("Index");
    }

    public IActionResult Edit(int id)
    { return View(); }

    [HttpPost]
    public IActionResult Edit(int id, EmployeeModel employeeModel)
    { 
      _IEmployeeBuisness.Edit(id,employeeModel);
      return View("Index"); 
    }

  }
}
