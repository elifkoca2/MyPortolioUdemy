using Microsoft.AspNetCore.Mvc;

namespace MyPortolioUdemy.Controllers
{
    public class ExperienceController : Controller
    {
        public IActionResult ExperienceList()
        {
            return View();
        }
    }
}
