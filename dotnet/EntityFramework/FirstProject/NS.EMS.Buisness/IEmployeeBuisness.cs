using NS.EMS.Model;

using System.Collections.Generic;

namespace NS.EMS.Buisness
{
  public interface IEmployeeBuisness
  {
    bool AddEmployee(EmployeeModel employeeModel);
    List<EmployeeDeptModel> Details();
    void Edit(int id, EmployeeModel employeeModel);
    void Delete(int id, EmployeeModel employeeModel);
  }
}
