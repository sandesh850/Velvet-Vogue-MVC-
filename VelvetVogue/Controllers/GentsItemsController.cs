using Microsoft.AspNetCore.Mvc;

namespace VelvetVogue.Controllers
{
    public class GentsItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
