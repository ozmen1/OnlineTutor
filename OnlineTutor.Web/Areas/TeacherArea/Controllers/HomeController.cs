using Microsoft.AspNetCore.Mvc;

namespace OnlineTutor.Web.Areas.TeacherArea.Controllers
{
    [Area("TeacherArea")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
