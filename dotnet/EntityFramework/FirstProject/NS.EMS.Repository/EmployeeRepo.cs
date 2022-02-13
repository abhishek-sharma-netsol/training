using NS.EMS.Model;
using NS.EMS.Data.Entities;

namespace NS.EMS.Repository
{
  public class EmployeeRepo: IEmployeeRepo
  {
    public bool AddEmployee(EmployeeModel employeeModel)
    {
      using (var context = new EmployeeDBContext())
      {
        Persons p = new Persons();
        p.Age = employeeModel.Age;
        p.FirstName = employeeModel.FirstName;
        p.FirstName = employeeModel.LastName;
        context.Persons.Add(p);
        context.SaveChanges();

      }
      return true;
    }
  }
}
