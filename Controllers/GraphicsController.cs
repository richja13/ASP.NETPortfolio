using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class GraphicsController : Controller
    {
        public readonly ApplicationDbContext _context;

        public GraphicsController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> GraphicsView() => _context.Graphics != null ? View(await _context.Graphics.ToListAsync()) : Problem("DbContext is null");
    }
}
