namespace ViewData.Models {
  public class EmployeeBuisnessLayer {
    public Employee GetEmployeeDetails(int EmployeeId){
      Employee employee = new Employee(){
        EmployeeId = EmployeeId,
        Name = "Pranaya",
        Gender = "Male",
        City = "Mumbai",
        Salary = 1000,
        Address = "Andheri"
      };
      return employee;
    }
  }
}
