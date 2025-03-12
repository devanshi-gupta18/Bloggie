using Microsoft.AspNetCore.Mvc;

namespace Blog.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
