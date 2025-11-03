using Microsoft.AspNetCore.Mvc;
using VelvetVogue.Models.ViewModels;

namespace VelvetVogue.Controllers
{
    public class InquiriesController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new InquiriesViewModel());
        }
    }
}
