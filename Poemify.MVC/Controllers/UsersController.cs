using Microsoft.AspNetCore.Mvc;
using Poemify.BLL.Models;
using Poemify.BLL.Interfaces;

namespace Poemify.MVC.Controllers
{
    public class UsersController : Controller
    {
        IUserService _userService;
        public UsersController(IUserService userService)
        {
                _userService= userService;
        }
        public IActionResult Index()
        {
            var model = _userService.ViewPoetsAsync();
            return View(model);
        }
        public IActionResult New()
        {
            return View(new CreateUserViewModel());
        }
        public async Task<IActionResult> Save(CreateUserViewModel model)
        {
            if (ModelState.IsValid)
            {

                var (successful, msg) = await _userService.CreateUserAsync(model);

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
