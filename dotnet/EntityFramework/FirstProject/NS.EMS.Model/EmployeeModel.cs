namespace NS.EMS.Model
{
    public class EmployeeModel 
    {
      public int Id { get; set; }
      public string LastName { get; set; }
      public string FirstName { get; set; }
      public int Age { get; set; }
      public Department DeptName { get; set; }  
      public enum Department  { DotNet, PHP }
    }

}
