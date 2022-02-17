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
    public IActionResult Create() {
      return View();
    }

    [HttpPost]
    public IActionResult Create(EmployeeModel employeeModel)
    {
      var res = _IEmployeeBuisness.AddEmployee(employeeModel);
      var result = _IEmployeeBuisness.Details();
      return View("Index", result);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    { return View(); }

    [HttpPost]
    public IActionResult Edit(int id, EmployeeModel employeeModel)
    { 
      _IEmployeeBuisness.Edit(id,employeeModel);
      var result = _IEmployeeBuisness.Details();
      return View("Index", result); 
    }

    public IActionResult Delete(int id, EmployeeModel employeeModel)
    {
      _IEmployeeBuisness.Delete(id, employeeModel);
      var result = _IEmployeeBuisness.Details();
      return View("Index", result);
    }

  }
}
