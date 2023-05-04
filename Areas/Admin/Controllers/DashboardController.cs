using EvaraMVC.Modals;
using Microsoft.AspNetCore.Mvc;

namespace EvaraMVC.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin")]
        public IActionResult Index()
        { 
            Slider slider = new Slider();   
            return View(slider);
        }
    }
}
