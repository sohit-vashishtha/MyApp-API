using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get(int id)
        {

            var result = new
            {
                sclassesList = 344 ,  // You can replace 'Admin' with dynamic role from the request if needed
                message = "success"
            };
            return Ok();
        }
    }
}
