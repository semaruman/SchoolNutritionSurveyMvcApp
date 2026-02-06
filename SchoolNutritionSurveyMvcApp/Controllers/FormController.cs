using Microsoft.AspNetCore.Mvc;

namespace SchoolNutritionSurveyMvcApp.Controllers
{
    public class FormController : Controller
    {
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
                var db = new UsersDb();
                db.AddToDatabase(user);
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
