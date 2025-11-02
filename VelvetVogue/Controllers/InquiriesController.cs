using Microsoft.AspNetCore.Mvc;

namespace VelvetVogue.Controllers
{
    public class InquiriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
