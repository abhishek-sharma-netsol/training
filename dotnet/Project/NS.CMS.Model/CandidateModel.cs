using Microsoft.AspNetCore.Http;

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace NS.CMS.Model 
{
  public class CandidateModel {
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    
    [DataType(DataType.Date)]
    public DateTime Dob { get; set; }
    public string Address { get; set; } = null!;
    public string Mobile { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Tech { get; set; } = null!;

    [DisplayName("Upload Image")]
    public IFormFile Image { get; set; }
  }
}
