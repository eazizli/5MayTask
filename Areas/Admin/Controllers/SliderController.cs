using EvaraMVC.DataContext;
using EvaraMVC.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaraMVC.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {

        private readonly EvaraDbContext _evardbContext;
        public SliderController(EvaraDbContext dbContext)
        {
            _evardbContext = dbContext;
        }
        public async Task<IActionResult> Index()
        {
           List< Slider> slider = await _evardbContext.Sliders.ToListAsync();
            return View(slider);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Creat(Slider title)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
             await _evardbContext.Sliders.AddAsync(title);
            await _evardbContext.SaveChangesAsync();

            return View();

        }
        public async Task<IActionResult> Delete(int id)
        {
            Slider slider= await _evardbContext.Sliders.FindAsync(id);
            _evardbContext.Sliders.Remove(slider);
            await _evardbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            Slider slider= await _evardbContext.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }
    }
}
