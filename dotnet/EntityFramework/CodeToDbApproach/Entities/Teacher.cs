using System.ComponentModel.DataAnnotations;

namespace CodeToDbApproach.Entities
{
  public class Teacher 
  {
    [Key]
    public int TeacherId { get; set; }
    public string TeacherName { get; set; }
  }
}
