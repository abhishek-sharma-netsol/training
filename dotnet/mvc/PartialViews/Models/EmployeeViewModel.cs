using System.Collections.Generic;
namespace PartialViews.Models
{
    public class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeAge { get; set; }
        public Gender EmployeeGender { get; set; } 
    }

    public enum Gender { Male, Female }
}
