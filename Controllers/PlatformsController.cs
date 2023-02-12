using SoftwareStore.Data;
using SoftwareStore.Data.Services;
using SoftwareStore.Data.Static;
using SoftwareStore.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftwareStore.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class PlatformsController : Controller
    {
        private readonly IPlatformsService _service;

        public PlatformsController(IPlatformsService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get: Platforms/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")]Platform Platform)
        {
            if (!ModelState.IsValid)
            {
                return View(Platform);
            }
            await _service.AddAsync(Platform);
            return RedirectToAction(nameof(Index));
        }

        //Get: Platforms/Details/1
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var PlatformDetails = await _service.GetByIdAsync(id);

            if (PlatformDetails == null) return View("NotFound");
            return View(PlatformDetails);
        }

        //Get: Platforms/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var PlatformDetails = await _service.GetByIdAsync(id);
            if (PlatformDetails == null) return View("NotFound");
            return View(PlatformDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FullName,ProfilePictureURL,Bio")] Platform Platform)
        {
            if (!ModelState.IsValid)
            {
                return View(Platform);
            }
            await _service.UpdateAsync(id, Platform);
            return RedirectToAction(nameof(Index));
        }

        //Get: Platforms/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var PlatformDetails = await _service.GetByIdAsync(id);
            if (PlatformDetails == null) return View("NotFound");
            return View(PlatformDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var PlatformDetails = await _service.GetByIdAsync(id);
            if (PlatformDetails == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
