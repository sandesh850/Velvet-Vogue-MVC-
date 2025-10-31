using Microsoft.AspNetCore.Mvc;

namespace VelvetVogue.Controllers
{
    public class CheckingCurrentLoginController : Controller
    {
        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
    }
}
