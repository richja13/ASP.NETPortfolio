using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SkillsController : Controller
    {
        ApplicationDbContext _context;

        public SkillsController(ApplicationDbContext context) => _context = context;
        
        public async Task<IActionResult> SkillsView() => _context.Skills != null ? View(await _context.Skills.ToListAsync()) : Problem("DbContext is null");
    }
}
