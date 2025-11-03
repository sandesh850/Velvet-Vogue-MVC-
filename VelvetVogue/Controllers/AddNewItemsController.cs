using Microsoft.AspNetCore.Mvc;

namespace VelvetVogue.Controllers
{
    public class AddNewItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
