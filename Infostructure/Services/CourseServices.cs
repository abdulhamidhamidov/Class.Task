using Dapper;
using Infostructure.Interfaces;
using Infostructure.Models;
using Npgsql;
using Infostructure;

namespace Infostructure.Services;

public class CourseServices: ICourseService
{
    private readonly ConText _connection;
    public CourseServices()
    {
        _connection =new ConText();
    }
    public bool CreateCourse(Course course)
    {
            var sql = "insert into courses(coursename, description, startdate, enddate) values (@CourseName,@Description, @StartDate, @EndDate);";
            var res = _connection.Connection().Execute(sql,course);
            return res > 0;
    }

    public List<Course> GetCourse()
    {
            var sql = "select * from courses";
            var res = _connection.Connection().Query<Course>(sql).ToList();
            return res;
    }

    public Course GetCourseById(int id)
    {
            var sql = "select * from courses where id=@Id";
            var res = _connection.Connection().QuerySingle<Course>(sql,new {Id=id});
            return res;
    }
    public bool Update(Course course)
    {
            var sql = "update courses set coursename=@CourseName ,description=@Description, startdate=@StartDate, enddate=@EndDate  where id=@Id;";
            var res = _connection.Connection().Execute(sql,course);
            return res > 0;
    }
    public bool Delete(int id)
    {
            var sql = "delete from courses where id=@Id";
            var res = _connection.Connection().Execute(sql,new {Id=id});
            return res > 0;
    }
}