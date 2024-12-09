using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyApp_API.Models;

namespace MyApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeController : ControllerBase
    {
        [HttpPost("NoticeCreate")]
        public IActionResult NoticeCreate([FromBody] NoticeModel  notice)
        {
            // Implement the logic for creating a notice
            return Ok();
        }

        [HttpGet("NoticeList/{id}")]
        public IActionResult NoticeList(int id)
        {
            // Implement the logic for getting the list of notices
            return Ok();
        }

        [HttpDelete("Notices/{id}")]
        public IActionResult DeleteNotices(int id)
        {
            // Implement the logic to delete notices
            return Ok();
        }

        [HttpPut("Notice/{id}")]
        public IActionResult UpdateNotice(int id, [FromBody] NoticeModel updatedNotice)
        {
            // Implement the logic to update a notice
            return Ok();
        }
    }
}
