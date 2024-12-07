namespace Infostructure.Models;

public class Group
{
    public int Id { get; set; }
    public int CourseId { get; set; }
    public string GroupName { get; set; }
    public int GroupSize { get; set; }
}