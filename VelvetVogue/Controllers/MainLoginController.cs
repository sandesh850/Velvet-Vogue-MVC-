using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class MainLoginController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new MainLoginViewModel());
        }
    }
}
