using Infostructure.Interfaces;
using Infostructure.Models;
using Npgsql;
using Dapper;
namespace Infostructure.Services;

public class MentorServices:IMentorService
{
    private readonly ConText _connection;
    public MentorServices()
    {
        _connection =new ConText();
    }
    public bool CreateMentor(Mentor mentor)
    {
            var sql = "insert into mentors(FullName, Email, PhoneNumber, CourseId) values (@FullName, @Email, @PhoneNumber, @CourseId);\n";
            var res = _connection.Connection().Execute(sql,mentor);
            return res > 0;
    }
    public List<Mentor> GetMentor()
    {
            var sql = "select * from mentors";
            var res = _connection.Connection().Query<Mentor>(sql).ToList();
            return res;
    }
    public Mentor GetMentorById(int id)
    {
            var sql = "select * from mentors where id=@Id";
            var res = _connection.Connection().QuerySingle<Mentor>(sql,new {Id=id});
            return res;
    }
    public bool Update(Mentor mentor)
    {
            var sql = "update mentors set FullName=@FullName, Email=@Email, PhoneNumber=@PhoneNumber, CourseId=@CourseId where id=@Id;";
            var res = _connection.Connection().Execute(sql,mentor);
            return res > 0;
    }
    public bool Delete(int id)
    {
            var sql = "delete from mentors where id=@Id";
            var res = _connection.Connection().Execute(sql,new {Id=id});
            return res > 0;
    }
}