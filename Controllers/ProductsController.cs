using SoftwareStore.Data;
using SoftwareStore.Data.Services;
using SoftwareStore.Data.Static;
using SoftwareStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ProductsController : Controller
    {
        private readonly IProductsService _service;

        public ProductsController(IProductsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allProducts = await _service.GetAllAsync(n => n.Platforms_Products);
            //var allProducts = await _service.GetAllAsync();
            return View(allProducts);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allProducts = await _service.GetAllAsync(n => n.Platforms_Products);
            //var allProducts = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                //var filteredResult = allProducts.Where(n => n.Name.ToLower().Contains(searchString.ToLower()) || n.Description.ToLower().Contains(searchString.ToLower())).ToList();

                var filteredResultNew = allProducts.Where(n => string.Equals(n.Name, searchString, StringComparison.CurrentCultureIgnoreCase) || string.Equals(n.Description, searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();

                return View("Index", filteredResultNew);
            }

            return View("Index", allProducts);
        }

        //GET: Products/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var ProductDetail = await _service.GetProductByIdAsync(id);
            return View(ProductDetail);
        }

        //GET: Products/Create
        public async Task<IActionResult> Create()
        {
            var ProductDropdownsData = await _service.GetNewProductDropdownsValues();

            ViewBag.Producers = new SelectList(ProductDropdownsData.Producers, "Id", "FullName");
            ViewBag.Platforms = new SelectList(ProductDropdownsData.Platforms, "Id", "FullName");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewProductVM Product)
        {
            if (!ModelState.IsValid)
            {
                var ProductDropdownsData = await _service.GetNewProductDropdownsValues();

                ViewBag.Producers = new SelectList(ProductDropdownsData.Producers, "Id", "FullName");
                ViewBag.Platforms = new SelectList(ProductDropdownsData.Platforms, "Id", "FullName");

                return View(Product);
            }

            await _service.AddNewProductAsync(Product);
            return RedirectToAction(nameof(Index));
        }


        //GET: Products/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var ProductDetails = await _service.GetProductByIdAsync(id);
            if (ProductDetails == null) return View("NotFound");

            var response = new NewProductVM()
            {
                Id = ProductDetails.Id,
                Name = ProductDetails.Name,
                Description = ProductDetails.Description,
                Price = ProductDetails.Price,
                ImageURL = ProductDetails.ImageURL,
                ProductCategory = ProductDetails.ProductCategory,
                ProducerId = ProductDetails.ProducerId,
                PlatformIds = ProductDetails.Platforms_Products.Select(n => n.PlatformId).ToList(),
            };

            var ProductDropdownsData = await _service.GetNewProductDropdownsValues();
            ViewBag.Producers = new SelectList(ProductDropdownsData.Producers, "Id", "FullName");
            ViewBag.Platforms = new SelectList(ProductDropdownsData.Platforms, "Id", "FullName");

            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewProductVM Product)
        {
            if (id != Product.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var ProductDropdownsData = await _service.GetNewProductDropdownsValues();

                ViewBag.Producers = new SelectList(ProductDropdownsData.Producers, "Id", "FullName");
                ViewBag.Platforms = new SelectList(ProductDropdownsData.Platforms, "Id", "FullName");

                return View(Product);
            }

            await _service.UpdateProductAsync(Product);
            return RedirectToAction(nameof(Index));
        }
    }
}