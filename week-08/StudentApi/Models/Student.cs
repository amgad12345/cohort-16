using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentApi.Models
{
  public class Student
  {
    public int Id { get; set; }

    [Required]
    public string FullName { get; set; }

    [Required]
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string SlackName { get; set; }
    public double? GPA { get; set; }
    public bool IsJoyful { get; set; } = true;

    public List<ProgressReport> ProgressReports { get; set; }
      = new List<ProgressReport>();
  }
}