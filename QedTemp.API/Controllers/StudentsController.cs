using Microsoft.AspNetCore.Mvc;
using QedTemp.Data;
using QedTemp.Models; 

namespace QedTemp.Controllers 
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase 
    {       
        private readonly MockStudentRepository _repository = new MockStudentRepository();

        //GET api/students 
        [HttpGet]
        public ActionResult <IEnumerable<Student>> GetAllStudents()
        {
            var students = _repository.GetAllStudents();

            return Ok(students);
        }

        //GET api/students/{id}
        [HttpGet("{id}")]
        public ActionResult <Student> GetStudentById(int id)
        {
            var student = _repository.GetStudentById(id);
            return Ok(student);
        }
    }
}