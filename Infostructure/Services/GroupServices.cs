using System.Text.RegularExpressions;
using Dapper;
using Infostructure.Interfaces;
using Npgsql;
using Dapper;
namespace Infostructure.Services;

public class GroupServices : IGroupService
{
    private readonly ConText _connection;
    public GroupServices()
    {
        _connection =new ConText();
    }
    public bool CreateGroup(Group group)
    {
            var sql = "insert into groups( courseid, groupname, groupsize) values (@CourseId,@GroupName,@GroupSize);";
            var res = _connection.Connection().Execute(sql,group);
            return res > 0;
    }
    public List<Group> GetGroup()
    {
            var sql = "select * from groups";
            var res = _connection.Connection().Query<Group>(sql).ToList();
            return res;
    }
    public Group GetGroupById(int id)
    {
            var sql = "select * from groups where id=@Id";
            var res = _connection.Connection().QuerySingle<Group>(sql,new {Id=id});
            return res;
    }
    public bool Update(Group group)
    {
            var sql = "update groups set courseid=@CourseId, groupname=@GroupName, groupsize=@GroupSize where id=@Id";
            var res = _connection.Connection().Execute(sql,group);
            return res > 0;
    }
    public bool Delete(int id)
    {
            var sql = "delete from groups where id=@Id";
            var res = _connection.Connection().Execute(sql,new {Id=id});
            return res > 0;
    }
}