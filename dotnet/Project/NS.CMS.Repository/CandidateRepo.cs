using NS.CMS.Model; 
using NS.CMS.Data.Entities;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace NS.CMS.Repository
{
  public class CandidateRepo: ICandidateRepo
  {
   
    
    // Get All Candidates
    public List<Candidate>  GetAllCandidates()
    {
      using (var context = new CandidateDbContext() )
      {
         //var res = context.Candidates.FromSqlRaw("Select * from Candidates").ToList();
         var res = context.Candidates.FromSqlRaw("UspSelectAllCandidates").ToList();
         return res;
      }
    }
   
    // Get Candidate By Id
    public List<Candidate> GetCandidateById(int id)
    {
      var context = new CandidateDbContext();
      //var result = context.Candidates.FromSqlRaw("select * from Candidates where Id=@id", new SqlParameter("@id", id));
      var result = context.Candidates.FromSqlRaw("UspSelectCandidateById @Id", new SqlParameter("@Id", id));
      return result.ToList();
    }

    // Add a new Candidae
    public bool AddCandidate(CandidateModel candidateModel, string currentPath)
    {
      string fileName = Path.GetFileNameWithoutExtension(candidateModel.Image.FileName);
      string fileExtension = Path.GetExtension(candidateModel.Image.FileName);

      string imageName = fileName + DateTime.Now.ToString("yymmssff") + fileExtension;
      string path = Path.Combine(currentPath + "/wwwroot/Image/", imageName);

      using (var fileStream = new FileStream(path,FileMode.Create))
      {
        candidateModel.Image.CopyToAsync(fileStream);
      }

      using (var context = new CandidateDbContext())
      {
        var Name = new SqlParameter("@Name", candidateModel.Name);
        var Dob  = new SqlParameter("@Dob", candidateModel.Dob); 
        var Address = new SqlParameter("@Address", candidateModel.Address); 
        var Mobile  = new SqlParameter("@Mobile", candidateModel.Mobile); 
        var Email   = new SqlParameter("@Email", candidateModel.Email); 
        var Tech    = new SqlParameter("@Tech", candidateModel.Tech); 
        var Image   = new SqlParameter("@Image", path);
        
        context.Database.ExecuteSqlRaw("UspInsertIntoCandidates @Name, @Dob, @Address, @Mobile, @Email, @Tech, @Image ", Name, Dob, Address, Mobile, Email, Tech, Image);
      }
      return true;

    }


    // Edit a Candit
    public bool Edit(int id, CandidateModel candidateModel)
    {
      using (var context = new CandidateDbContext())
      {
        var personWithId = context.Candidates.SingleOrDefault(p => p.Id == id);
        if(personWithId != null)
        {
          personWithId.Name = candidateModel.Name;
          personWithId.Dob  = candidateModel.Dob;
          personWithId.Address = candidateModel.Address;
          personWithId.Mobile  = candidateModel.Mobile;
          personWithId.Email   = candidateModel.Email;
          personWithId.Tech    = candidateModel.Tech;
          context.SaveChanges();
          return true;
        }
        return false;
      }
    }


    // Delete a Candidate
    public bool Delete(int id, CandidateModel candidateModel)
    {
      using (var context = new CandidateDbContext())
      {
        var personWithId = context.Candidates.SingleOrDefault(x => x.Id == id);
        if(personWithId != null)
        {
          context.Remove(personWithId);
          context.SaveChanges();
          return true;
        }
        return false;
      }
    }
  }
}
