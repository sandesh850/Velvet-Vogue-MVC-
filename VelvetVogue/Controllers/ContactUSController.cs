using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class ContactUSController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new ContactUSViewModel());
        }

        [HttpPost]
        public IActionResult Index(ContactUSViewModel Model)
        {
            return View();
        }
    }
}
