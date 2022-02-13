using NS.EMS.Model;

namespace NS.EMS.Repository
{
  public interface IEmployeeRepo
  {
    bool AddEmployee(EmployeeModel employeeModel);
  }
}
