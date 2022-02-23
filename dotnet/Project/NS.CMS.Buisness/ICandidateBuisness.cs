using NS.CMS.Data.Entities;
using NS.CMS.Model;

namespace NS.CMS.Buisness
{
  public interface ICandidateBuisness
  {
    public List<Candidate> GetAllCandidates();
    public bool AddCandidate(CandidateModel candidateModel);
    public bool Edit(int id, CandidateModel candidateModel);
    public List<Candidate> GetCandidateById(int id);
    public bool Delete(int id, CandidateModel candidateModel);
  }
}
