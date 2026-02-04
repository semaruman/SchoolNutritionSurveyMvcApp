using Microsoft.AspNetCore.Mvc;

namespace SchoolNutritionSurveyMvcApp.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }
    }
}
