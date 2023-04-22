using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Storyteller_2._0.Data;
using Storyteller_2._0.Data.Services;
using Storyteller_2._0.Models;

namespace Storyteller_2._0.Controllers
{
    public class ComicsController : Controller
    {
        private readonly IComicsService _service;
        public ComicsController(IComicsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data =await _service.GetAll();
            return View(data);
        } 
        public async Task<IActionResult> Create()
        {
            return View();
        }
    }
}
