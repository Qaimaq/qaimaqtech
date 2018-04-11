using Microsoft.AspNetCore.Mvc;

namespace Qaimaq.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}