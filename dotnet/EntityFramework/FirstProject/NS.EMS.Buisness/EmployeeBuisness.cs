using NS.EMS.Repository;
using NS.EMS.Model;

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
    
  }
}
