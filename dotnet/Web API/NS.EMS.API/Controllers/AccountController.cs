using System.Text;
using NS.EMS.API.Entities;
using System.Security.Claims;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;

namespace NS.EMS.API.Controllers 
{
  [ApiController]
  [Route("api/[controller]/[action]")]

  public class AccountController: ControllerBase {
    private readonly IConfiguration _configuration;

    public AccountController(IConfiguration configuration)
    {
      _configuration = configuration;
    }

    [HttpPost]
    public IActionResult Login(Login login)
    {
      using (var contect=new EmployeeDbContext())
      {
        var user = contect.Logins.Where(x => x.UserName == login.UserName && x.Password == login.Password && x.IsActive == true ).FirstOrDefault();
        if(user != null)
        {
          var token = GenerateToken(user.UserName, user.Role);
          return Ok(token);
        }
        else return Ok("Invalid UserName and Password");
      }
      return Ok();
    }

    private string GenerateToken(string username, string role)
    {
      var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
      var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
      var claims = new Claim[] { new (ClaimTypes.Name,""), new (ClaimTypes.Role,"") };
      var token  = new JwtSecurityToken(
          _configuration["Jwt:Issuer"],
          _configuration["Jwt:Audience"],
          claims,
          expires:DateTime.Now.AddMinutes(30),
          signingCredentials: credentials
      );

      return new JwtSecurityTokenHandler().WriteToken(token);
    }
  }
}
