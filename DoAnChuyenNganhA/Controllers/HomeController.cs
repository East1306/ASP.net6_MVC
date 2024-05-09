using DoAnChuyenNganhA.Data;
using DoAnChuyenNganhA.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DoAnChuyenNganhA.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HotelDatabaseContext _dbContext;

        public HomeController(ILogger<HomeController> logger, HotelDatabaseContext context)
        {
            _logger = logger;
            this._dbContext = context;
        }

        public IActionResult Index()
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