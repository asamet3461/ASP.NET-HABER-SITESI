using Microsoft.AspNetCore.Mvc;
using UluHaber.Data;
using Microsoft.EntityFrameworkCore;

namespace UluHaber.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(string slug)
        {
            var model = _context.Categories.Include(p=> p.Posts).FirstOrDefault(c=> c.Slug.ToLower() == slug.ToLower());
            if (model == null)
            {
                return NotFound();
            }
            return View(model);
        }
    }
}
