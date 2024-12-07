using Infostructure.Interfaces;
using Infostructure.Models;
using Npgsql;
using Dapper;
namespace Infostructure.Services;

public class StudentServices: IStudentService
{
    private readonly ConText _connection;
    public StudentServices()
    {
        _connection =new ConText();
    }
    public bool CreateStudent(Student student)
    {
            var sql = "insert into students(FullName, Email, PhoneNumber, CourseId) values (@FullName, @Email, @PhoneNumber, @CourseId);";
            var res = _connection.Connection().Execute(sql,student);
            return res > 0;
    }

    public List<Student> GetStudent()
    {
             var sql = "select * from students";
            var res = _connection.Connection().Query<Student>(sql).ToList();
            return res;
    }

    public Student GetStudentById(int id)
    {
            var sql = "select * from students where id=@Id";
            var res = _connection.Connection().QuerySingle<Student>(sql,new {Id=id});
            return res;
    }
    public bool Update(Student student)
    {   
            var sql = "update mentors set FullName=@FullName, Email=@Email, PhoneNumber=@PhoneNumber, CourseId=@CourseId where id=@Id;\n";
            var res = _connection.Connection().Execute(sql,student);
            return res > 0;
    }
    public bool Delete(int id)
    {
            var sql = "delete from studnets";
            var res = _connection.Connection().Execute(sql,new {Id=id});
            return res > 0;
    }
}