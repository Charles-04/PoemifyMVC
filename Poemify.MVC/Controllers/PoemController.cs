using Microsoft.AspNetCore.Mvc;

namespace Poemify.MVC.Controllers
{
    public class PoemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
