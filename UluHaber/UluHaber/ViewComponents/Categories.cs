using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UluHaber.Data;

namespace UluHaber.ViewComponents
{
    public class Categories : ViewComponent
    {
        private readonly ApplicationDbContext _database;

        public Categories(ApplicationDbContext database)
        {
            _database = database;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _database.Categories.ToListAsync());
        }
    }
}
