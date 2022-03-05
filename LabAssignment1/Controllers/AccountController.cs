using LabAssignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace LabAssignment1.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignUp()
        {
            UserViewModel model = new UserViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult SignUp(UserViewModel userModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }

        [HttpGet]
        public IActionResult GetCityByCountry(int countryId)
        {
            UserViewModel model = new UserViewModel();

            return Json(model.GetCityByCountryId(Convert.ToInt32(countryId)));
        }
    }
}
