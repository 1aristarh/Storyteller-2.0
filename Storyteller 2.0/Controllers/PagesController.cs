using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Storyteller_2._0.Data;

namespace Storyteller_2._0.Controllers
{
    public class PagesController : Controller
    {
        private readonly AppDbContext _context;
        public PagesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _context.Pages.ToListAsync();
            return View();
        }
    }
}
