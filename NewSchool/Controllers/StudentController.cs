using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NewSchool.Database;
using NewSchool.Model;

namespace NewSchool.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        private readonly ApplicationDbContext _db; 
        public StudentController(ApplicationDbContext db) {
            _db = db;

        }



        [HttpGet]
        public IActionResult getStudents()
        {
            List<Students> students= new List<Students>();
            students = _db.Students.ToList();
            return Ok (students); 


        }


        [HttpPost]
        public IActionResult createStudent([FromBody] Students students)
        {
            _db.Add(students);
            _db.SaveChanges();
            return(Ok(students));

        }

    }
}
