using EvaraMVC.DataContext;
using EvaraMVC.Modals;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EvaraMVC.Areas.Admin.Controllers
{
        [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly EvaraDbContext _evardbContext;
       // private redonly EvaraDbContext _evarDbContext;

        public CategoryController(EvaraDbContext dbContext)
        {
            _evardbContext = dbContext;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> categories=await _evardbContext.Categories.ToListAsync();
            return View(categories);
        }
        public async Task<IActionResult> Detail(int id)
        {
            Category? category=await _evardbContext.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();  
            }
            return View(category);
        }
        public async Task<IActionResult> Create()
        {
            return View();  
        }
        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            return View();
        }
    }
}
