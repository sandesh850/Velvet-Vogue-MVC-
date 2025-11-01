using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class UpdatingLoginDetailsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new NewLoginDetailsViewModel());
        }
    }
}
