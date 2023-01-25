using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SoftwareStore.Data;

namespace SoftwareStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           // var allProducts = await _context.Products.ToListAsync();
            var allProducts = await _context.Products.ToListAsync();
            //var allProducts = await _context.Products.Include(n => n.Products).OrderBy(n => n.Name).ToListAsync();
            return View(allProducts);
        }
    }
}
