namespace Infostructure.Models;

public class Course
{
    public int Id { get; set; }
    public string CourseName { get; set; }
    public string Description { get; set; }
    public DateTime StartDate {get;set; }
    public DateTime EndDate {get;set; }
}