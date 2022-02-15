using NS.EMS.Model;
using NS.EMS.Data.Entities;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace NS.EMS.Repository
{
  public class EmployeeRepo: IEmployeeRepo
  {
    public bool AddEmployee(EmployeeModel employeeModel)
    {
      using (var context = new EmployeeDBContext())
      {

        var department = context.EmployeeDept.SingleOrDefault(i => i.DeptName == employeeModel.DeptName.ToString());
        var firstName = new SqlParameter("@FirstName", employeeModel.FirstName);
        var lastName = new SqlParameter("@LastName", employeeModel.LastName); 
        var age = new SqlParameter("@Age", employeeModel.Age); 
        var employeeId = new SqlParameter("@EmployeeId", department.EmployeeId);
      
        // Using Stored Parameter
        context.Database.ExecuteSqlRaw("usp_InsertIntoPerson @FirstName, @LastName, @Age, @EmployeeId", firstName, lastName, age, employeeId );
        
        //context.Person.Add(p);
        //context.SaveChanges();
      }
      return true;
    }

    public List<EmployeeDeptModel> Details()
    {
      var context = new EmployeeDBContext();
      var empData = context.EmpDpt.FromSqlRaw("usp_GetEmployees").ToList();

      //var result = context.Person.FromSqlRaw("usp_GetEmployees").ToList();
      //var employeeModel = context.Person.ToList();

      return empData;
    }

    public void Edit(int id, EmployeeModel employeeModel)
    {
      using (var context = new EmployeeDBContext())
      {
        var personWithId = context.Person.SingleOrDefault(p => p.Id == id);
        if(personWithId != null)
        {
          personWithId.FirstName = employeeModel.FirstName;
          personWithId.LastName = employeeModel.LastName;
          personWithId.Age = employeeModel.Age;
          context.SaveChanges();
        }
      }
    }
  }
}
