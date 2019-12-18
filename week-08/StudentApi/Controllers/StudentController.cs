using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StudentApi.Models;

namespace StudentApi.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class StudentController : ControllerBase
  {

    [HttpGet]
    public ActionResult GetAllStudents()
    {
      // return a list of all students ordered by fullname
      var db = new DatabaseContext();
      return Ok(db.Students.OrderBy(student => student.FullName));
    }

    [HttpPost]
    public ActionResult CreateStudent(Student student)
    {
      var db = new DatabaseContext();
      db.Students.Add(student);
      db.SaveChanges();
      return Ok(student);
    }

  }
}