using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class CheckingCurrentLoginController : Controller
    {
        [HttpPost]
        public IActionResult Index(CheckingCurrentLoginViewModel Model)
        {
            return View();
        }
    }
}
