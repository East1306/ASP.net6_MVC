using Microsoft.AspNetCore.Mvc;

namespace DoAnChuyenNganhA.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
