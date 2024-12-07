
using Infostructure.Models;

namespace Infostructure.Interfaces;

public interface ICourseService
{
   bool CreateCourse(Course course);
   List<Course> GetCourse();
   Course GetCourseById(int id);
   bool Update(Course course);
   bool Delete(int id);
}