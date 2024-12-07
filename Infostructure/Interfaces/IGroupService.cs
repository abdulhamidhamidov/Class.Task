using System.Text.RegularExpressions;

namespace Infostructure.Interfaces;

public interface IGroupService
{
    bool CreateGroup(Group group);
    List<Group> GetGroup();
    Group GetGroupById(int id);
    bool Update(Group group);
    bool Delete(int id);
}