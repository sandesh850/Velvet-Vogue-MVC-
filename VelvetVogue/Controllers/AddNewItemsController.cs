using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class AddNewItemsController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new AddNewItemsViewModel());
        }
    }
}
