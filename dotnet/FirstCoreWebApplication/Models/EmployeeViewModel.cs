using System.Collections.Generic;

namespace FirstCoreWebApplication.Models {

  public class EmployeeViewModel {
    public EmployeeViewModel(){
      Employees = new List<Employee>();
    }
    public List<Employee> Employees { get; set; }
  }
  
  public class Employee {
    public int EmployeeId { get; set; }
    public string EmployeeName { get; set; }
    public string EmployeeDob { get; set; }
    public string EmployeeSalary { get; set; }
  }
}
