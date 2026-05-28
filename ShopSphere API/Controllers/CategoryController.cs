using Microsoft.AspNetCore.Mvc;
using ShopSphere_API.Data;
using ShopSphere_API.Models;
using Microsoft.EntityFrameworkCore;

namespace ShopSphere_API.Controllers
{
    public class CategoryController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _context.Categories.ToListAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return Ok(category);
        }
    }
}
