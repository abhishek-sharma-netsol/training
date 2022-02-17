using NS.EMS.Repository;
using NS.EMS.Model;
using System.Collections.Generic;
using NS.EMS.Data.Entities;

namespace NS.EMS.Buisness
{
  public class EmployeeBuisness: IEmployeeBuisness 
  {
    private readonly IEmployeeRepo _IEmployeeRepo = null;
    public EmployeeBuisness(IEmployeeRepo IEmployeeRepo)
    {
      _IEmployeeRepo = IEmployeeRepo;
    }

    public bool AddEmployee(EmployeeModel employeeModel)
    {
      return _IEmployeeRepo.AddEmployee(employeeModel);
    }

    public List<EmployeeDeptModel> Details()
    {
      return _IEmployeeRepo.Details();
    }
    
    public void Edit(int id, EmployeeModel employeeModel)
    {
      _IEmployeeRepo.Edit(id,employeeModel);
    }

    public void Delete( int id, EmployeeModel employeeModel)
    {
      _IEmployeeRepo.Delete(id, employeeModel);
    }
  }
}
