using NS.CMS.Data.Entities;
using NS.CMS.Repository;
using NS.CMS.Model;

namespace NS.CMS.Buisness
{
  public class CandidateBuisness: ICandidateBuisness
  {
    private readonly ICandidateRepo _ICandidateRepo; 
    public CandidateBuisness(ICandidateRepo ICandidateRepo)
    {
      _ICandidateRepo = ICandidateRepo;
    }

    public List<Candidate> GetAllCandidates(){
      return _ICandidateRepo.GetAllCandidates();
    }

    public bool AddCandidate(CandidateModel candidateModel)
    {
      return _ICandidateRepo.AddCandidate(candidateModel);
    }

    public bool Edit(int id, CandidateModel candidateModel)
    {
      return _ICandidateRepo.Edit(id, candidateModel);
    }

    public List<Candidate> GetCandidateById(int id)
    {
      return _ICandidateRepo.GetCandidateById(id);
    }

    public bool Delete(int id, CandidateModel candidateModel)
    {
      return _ICandidateRepo.Delete(id, candidateModel);
    }
  }
}
