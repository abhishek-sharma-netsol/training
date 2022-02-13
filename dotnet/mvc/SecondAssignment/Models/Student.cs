using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace SecondAssignment.Models {

  public class Student {
    public int Id;
    [Required(ErrorMessage = "Name cannot be empty")]
    [StringLength(10)]
    public string Name;

    [Required]
    public string Branch;

    [Required]
    public string Section;

    [Required]
    public string Gender; 
    
    [Required]
    [Range(20,40, ErrorMessage = "Age must be between 20 and 40")]
    public int Age;
  }
}
