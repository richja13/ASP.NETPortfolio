using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class NetController : Controller
    {
        public readonly ApplicationDbContext _context;

        public NetController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> NetProjectsView(string projectID)
        {
            ViewBag.ProjectID = projectID;
            return _context.NetProjects != null ? View(await _context.NetProjects.ToListAsync()) : Problem("DbContext is null");
        }
    }
}
