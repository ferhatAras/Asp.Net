using Microsoft.AspNetCore.Mvc;

namespace AspNet.Controllers
{
    [Route("course")]
    public class CourseController : Controller
    {
        [HttpGet("index")]
        public string Index()
        {
            return "course/index";
        }

        [HttpGet("list")]
        public string List()
        {
            return "course/list";
        }
    }
}
