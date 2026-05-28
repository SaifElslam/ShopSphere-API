using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopSphere_API.Data;
using ShopSphere_API.Models;
using Microsoft.EntityFrameworkCore;
namespace ShopSphere_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetCart()
        {
            var cart = await _context.CartItems.Include(x => x.Product).ToListAsync();
            return Ok(cart);
        }

        [HttpPost]
        public async Task<IActionResult> AddToCart(CarItem item)
          
        {
            await _context.CartItems.AddAsync(item);
            await _context.SaveChangesAsync();

            return Ok(item);
        }
    }
}

