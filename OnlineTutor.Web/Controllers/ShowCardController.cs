using Microsoft.AspNetCore.Mvc;

namespace OnlineTutor.Web.Controllers
{
    public class ShowCardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
