using Microsoft.AspNetCore.Mvc;

namespace Qaimaq.Controllers
{
   // [RequireHttps]
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}