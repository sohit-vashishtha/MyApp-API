using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp_API.Models;

namespace MyApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        // POST: api/AdminLogin
        [HttpPost("AdminLogin")]
        public IActionResult TeacherLogin([FromBody]  TeacherModel request)
        {

            
            var result = new
            {

                role = "Teacher",//u can replace 'Admin' with dynamic role from the request if needed
                message = "success"
            };

            return Ok(result);
        }
    }
}
