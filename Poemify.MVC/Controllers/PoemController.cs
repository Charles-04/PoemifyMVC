using Microsoft.AspNetCore.Mvc;
using Poemify.BLL.Interfaces;
using Poemify.BLL.Models;

namespace Poemify.MVC.Controllers
{
    public class PoemController : Controller
    {
        private readonly IPoemService _poemService;
        public PoemController(IPoemService poemService)
        {
            _poemService = poemService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult New()
        {
            return View(new CreateAndUpdatePoemViewModel());
        }
		public IActionResult Delete()
		{
			return View();
			
		}
		public IActionResult Edit()
		{
			return View();
		}
        [HttpPost]
        public async Task<IActionResult> Save(CreateAndUpdatePoemViewModel model)
        {
            if (ModelState.IsValid)
            {

                var (successful, msg) = await _poemService.CreateAndUpdatePoemAsync(model);

                if (successful)
                {

                    TempData["SuccessMsg"] = msg;

                    return RedirectToAction("Index");
                }

                

                ViewBag.ErrMsg = msg;

                return View("New");

            }

            return View("New");

        }


    }
}
