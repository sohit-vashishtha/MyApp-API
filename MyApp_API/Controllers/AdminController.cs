using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp_API.Models;

namespace MyApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        // POST: api/AdminReg
        [HttpPost("AdminReg")]
        public IActionResult AdminRegister([FromBody] AdminModel admin)
        {
            // Implement the logic for admin registration
            return Ok();
        }

        // POST: api/AdminLogin
        [HttpPost("AdminLogin")]
        public IActionResult AdminLogin([FromBody] AdminLoginRequest request)
        {
            var result = new
            {
                role = "Admin" ,  // You can replace 'Admin' with dynamic role from the request if needed
                message = "success"
            };

            return Ok(result);
        }

        // GET: api/Admin/{id}
        [HttpGet("Admin/{id}")]
        public IActionResult GetAdminDetail(int id)
        {
            // Implement the logic to get admin details
            return Ok();
        }

        // You can add more routes as necessary
    }
}
