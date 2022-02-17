using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeToDbApproach.Entities {

  [Table("StudentMaster")]
  public class Student 
  {
    [Key]
    public int StudentId { get; set; }

    [Column("StudentName", TypeName ="varchar(50)")]
    [Required]
    public string Name { get; set; }

    [NotMapped]
    public int Age { get; set; }

    [Required]
    public string Email { get; set; }

    public int TeacherId { get; set; }
    [ForeignKey("TeacherId")]

    public virtual Teacher Teacher {get; set; }
  }
}
