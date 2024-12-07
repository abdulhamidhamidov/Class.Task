using Infostructure.Models;

namespace Infostructure.Interfaces;

public interface IMentorService
{
    bool CreateMentor(Mentor mentor);
    List<Mentor> GetMentor();
    Mentor GetMentorById(int id);
    bool Update(Mentor mentor);
    bool Delete(int id);
}