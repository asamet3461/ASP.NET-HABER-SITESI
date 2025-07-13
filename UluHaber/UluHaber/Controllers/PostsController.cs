using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UluHaber.Data;

namespace UluHaber.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PostsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> IndexAsync()
        {
            var model = await _context.Posts.ToListAsync();
            return View(model);
        }
    
        public async Task<IActionResult> SearchAsync(string kelime)
        {
            var model = await _context.Posts.Where(p => p.Title.Contains(kelime) || p.AuthorName.Contains(kelime)).ToListAsync();
            return View(model);
        }
    
    
        public async Task<IActionResult> Detail(int id)
        {
            var model = await _context.Posts.FindAsync(id);
            return View(model);
        }
    }
}
