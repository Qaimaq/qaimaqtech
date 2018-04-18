using Microsoft.AspNetCore.Mvc;

namespace Qaimaq.Controllers
{
   // [RequireHttps]
    public class ServicesController : Controller
    {
        public IActionResult BI()
        {
            return View();
        }
        public IActionResult WebDev()
        {
            return View();
        }
        public IActionResult Video_Surveillance_System()
        {
            return View();
        }
        public IActionResult Structured_Cabling()
        {
            return View();
        }
        public IActionResult IT_Outsourcing()
        {
            return View();
        }
        public IActionResult IT_Consulting()
        {
            return View();
        }
        public IActionResult Fire_Alarm_System()
        {
            return View();
        }
        public IActionResult Alerting_System()
        {
            return View();
        }
        public IActionResult Access_control()
        {
            return View();
        }
    }
}