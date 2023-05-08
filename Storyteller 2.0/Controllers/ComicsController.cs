using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Storyteller_2._0.Data;
using Storyteller_2._0.Data.Enum;
using Storyteller_2._0.Data.Services;
using Storyteller_2._0.Data.Stoned;
using Storyteller_2._0.Models;
using System.Data;

namespace Storyteller_2._0.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ComicsController : Controller
    {
        private readonly IComicsService _service;
        public ComicsController(IComicsService service)
        {
            _service = service;
        }
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAllAsync();
            return View(data);
        } 
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("Name,PageCount,Genre,Size,Description,Type")]Comic comic)
        {
            if(ModelState.IsValid)
            {
                return View(comic);
            }
           await _service.AddAsync(comic);
            return RedirectToAction(nameof(Index));  
        }
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var comicdetails = await _service.GetbyIdAsync(id);
                if (comicdetails == null) return View("Notfound");
                    return View(comicdetails);  
        }
        public async Task<IActionResult> Edit(int id)
        {
            var comicdetails = await _service.GetbyIdAsync(id);
            if (comicdetails == null) return View("Notfound");
            return View(comicdetails);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id,[Bind("Id,Name,PageCount,Genre,Size,Description,Type")] Comic comic)
        {
            if (ModelState.IsValid)
            {
                return View(comic);
            }
            await _service.UpdateAsync(id,comic);
            return RedirectToAction(nameof(Index));
        }
        
        public async Task<IActionResult> Delete(int id)
        { var comicdetails = await _service.GetbyIdAsync(id);
            if (comicdetails == null) return View("Not found");
            return View(comicdetails);  
        }
        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)             
        {
            var comicdetails = await _service.GetbyIdAsync(id);
            if (comicdetails == null) return View("Not found");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
