using SoftwareStore.Data.Base;
using SoftwareStore.Data.ViewModels;
using SoftwareStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public async Task AddNewProductAsync(NewProductVM data)
        {
            var newProduct = new Product()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                ProductCategory = data.ProductCategory,
                ProducerId = data.ProducerId
            };
            await _context.Products.AddAsync(newProduct);
            await _context.SaveChangesAsync();

            //Add Product Platforms
            foreach (var platformId in data.platformIds)
            {
                var newplatformProduct = new Platform_Product()
                {
                    ProductId = newProduct.Id,
                    platformId = platformId
                };
                await _context.Platforms_Products.AddAsync(newplatformProduct);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            var ProductDetails = await _context.Products
                .Include(p => p.Producer)
                .Include(am => am.Platforms_Products).ThenInclude(a => a.platform)
                .FirstOrDefaultAsync(n => n.Id == id);

            return ProductDetails;
        }

        public async Task<NewProductDropdownsVM> GetNewProductDropdownsValues()
        {
            var response = new NewProductDropdownsVM()
            {
                Platforms = await _context.Platforms.OrderBy(n => n.FullName).ToListAsync(),
                Producers = await _context.Producers.OrderBy(n => n.FullName).ToListAsync()
            };

            return response;
        }

        public async Task UpdateProductAsync(NewProductVM data)
        {
            var dbProduct = await _context.Products.FirstOrDefaultAsync(n => n.Id == data.Id);

            if(dbProduct != null)
            {
                dbProduct.Name = data.Name;
                dbProduct.Description = data.Description;
                dbProduct.Price = data.Price;
                dbProduct.ImageURL = data.ImageURL;
                dbProduct.ProductCategory = data.ProductCategory;
                dbProduct.ProducerId = data.ProducerId;
                await _context.SaveChangesAsync();
            }

            //Remove existing Platforms
            var existingPlatformsDb = _context.Platforms_Products.Where(n => n.ProductId == data.Id).ToList();
            _context.Platforms_Products.RemoveRange(existingPlatformsDb);
            await _context.SaveChangesAsync();

            //Add Product Platforms
            foreach (var platformId in data.PlatformId)
            {
                var newplatformProduct = new Platform_Product()
                {
                    ProductId = data.Id,
                    PlatformId = platformId
                };
                await _context.Platforms_Products.AddAsync(newPlatformProduct);
            }
            await _context.SaveChangesAsync();
        }
    }
}
