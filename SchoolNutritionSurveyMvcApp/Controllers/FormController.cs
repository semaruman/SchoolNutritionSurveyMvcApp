using Microsoft.AspNetCore.Mvc;
using SchoolNutritionSurveyMvcApp.Services.Interfaces;

namespace SchoolNutritionSurveyMvcApp.Controllers
{
    public class FormController : Controller
    {
        private IUserService _userService;

        public FormController(IUserService userService)
        {
            _userService = userService;
        }

        public IActionResult Index()
        {
            return RedirectToAction("DoTest");
            //return View();
        }

        [HttpGet]
        public IActionResult DoTest()
        {
            return View(new UserFormModel());
        }

        [HttpPost]
        public IActionResult DoTest(UserFormModel user)
        {
            if (ModelState.IsValid)
            {
                _userService.AddToDatabase(user);
                return RedirectToAction("Result");
            }
            return View(user);
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
