using Microsoft.AspNetCore.Mvc;

namespace Petkit.Areas.Admin.Controllers
{
    public class TagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
