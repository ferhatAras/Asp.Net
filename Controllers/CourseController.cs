using Microsoft.AspNetCore.Mvc;

namespace AspNet.Controllers
{
    
    public class CourseController : Controller
    {


        
        public IActionResult Index()
        {
            return View();
        }

 
        public string List()
        {
            return "course/list";
        }
    }
}
