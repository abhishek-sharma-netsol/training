using NS.EMS.Model;
using System.Collections.Generic;

namespace NS.EMS.Repository
{
  public interface IEmployeeRepo
  {
    bool AddEmployee(EmployeeModel employeeModel);

    List<EmployeeDeptModel> Details();

    void Edit(int id, EmployeeModel employeeModel);

    void Delete(int id, EmployeeModel employeeModel);
  }
}
