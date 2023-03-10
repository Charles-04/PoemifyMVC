using Microsoft.AspNetCore.Mvc;

namespace Poemify.MVC.Controllers
{
    public class PoemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View();
        }
		public IActionResult Delete()
		{
			return View();
			
		}
		public IActionResult Edit()
		{
			return View();
		}
		public IActionResult Save()
		{
			return View();
		}

	}
}
