using Infostructure.Models;

namespace Infostructure.Interfaces;

public interface IStudentService
{
    bool CreateStudent(Student student);
    List<Student> GetStudent();
    Student GetStudentById(int id);
    bool Update(Student student);
    bool Delete(int id);
}