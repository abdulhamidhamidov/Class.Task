﻿namespace Infostructure.Models;

public class Mentor
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public int CourseId { get; set; }
}