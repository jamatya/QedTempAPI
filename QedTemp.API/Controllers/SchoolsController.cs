using Microsoft.AspNetCore.Mvc;
using QedTemp.Data;
using QedTemp.Models;

namespace QedTemp.Controllers
{
    [Route("api/schools")]
    [ApiController]
    public class SchoolsController : ControllerBase 
    {
        private readonly MockSchoolRepository _repository = new MockSchoolRepository();

        //GET api/schools
        [HttpGet]
        public ActionResult <IEnumerable<SchoolsController>> GetAllSchools()
        {
            var schools = _repository.GetAllSchools();

            return Ok(schools);
        }

        //GET api/schools/{id}
        [HttpGet("{id}")]
        public ActionResult <School> GetSchoolById(int id)
        {
            var school = _repository.GetSchoolById(id);
            return Ok(school);
        }
    } 
}

 