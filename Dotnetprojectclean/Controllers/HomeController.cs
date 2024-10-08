using Dotnetprojectclean.Models;
using Microsoft.AspNetCore.Mvc;
using Project.Appliction.Interfaces;
using Project.Appliction.Services.Implementation;
using Project.Domain.Entities;
using System.Diagnostics;

namespace Dotnetprojectclean.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ProductServices _productService;


        public HomeController(ILogger<HomeController> logger,ProductServices productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllAsync();
            
            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
