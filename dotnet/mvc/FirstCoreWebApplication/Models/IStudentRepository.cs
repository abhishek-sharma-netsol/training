using System.Collections.Generic;

namespace FirstCoreWebApplication.Models {

  public interface IStudentRepository {
    Student GetStudentById(int StudentId);
    List<Student> GetAllStudent();
  }

}
