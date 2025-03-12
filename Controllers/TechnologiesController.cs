using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class TechnologiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
