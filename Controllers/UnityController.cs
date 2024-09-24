using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Portfolio.Models;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class UnityController : Controller
    {
        public readonly ApplicationDbContext _context;

        public UnityController(ApplicationDbContext context) => _context = context;

      
        public async Task<IActionResult> UnityView()
        {
            return _context.UnityProjects !=null ? View(await _context.UnityProjects.ToListAsync()) : Problem("DbContext is null");
        }
	}
}

