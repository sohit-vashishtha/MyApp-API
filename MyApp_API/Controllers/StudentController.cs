using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp_API.Models;

namespace MyApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost("StudentReg")]
        public IActionResult StudentRegister([FromBody] StudentModel student)
        {
            // Implement student registration logic
            return Ok();
        }

        [HttpPost("StudentLogin")]
            // Implement the logic for creating a notice
        public IActionResult StudentLogin([FromBody]   StudentLoginRequest   request)
        {

            var result = new
            {
                role = "Student",//You can replace 'Admin' with dynamic role from the request if needed
                message = "success"
            };
            // Implement student login logic
            return Ok();
        }

        [HttpGet("Students/{id}")]
        public IActionResult GetStudents(int id)
        {
            // Implement logic to get students
            return Ok();
        }

        [HttpGet("Student/{id}")]
        public IActionResult GetStudentDetail(int id)
        {
            // Get student detail by ID
            return Ok();
        }

        [HttpDelete("Students/{id}")]
        public IActionResult DeleteStudents(int id)
        {
            // Implement delete logic for student
            return Ok();
        }

        // Implement other student-related actions similarly
    }

}
