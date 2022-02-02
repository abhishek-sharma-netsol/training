using System.Collections.Generic;
using FirstCoreWebApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstCoreWebApplication.Controllers {
  public class HomeController: Controller {
    
    public JsonResult Index(){
      TestStudentRepository repository = new TestStudentRepository();
      List<Student> allStudentDetails = repository.GetAllStudent();
      return Json(allStudentDetails);
    }

    public JsonResult GetStudentDetails(int Id){
      TestStudentRepository repository = new TestStudentRepository();
      Student studentDetails = repository.GetStudentById(Id);
      return Json(studentDetails);
    }

  }
}
