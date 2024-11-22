using Microsoft.AspNetCore.Mvc;

namespace QuanLyKTX.Controllers
{
    [Area("Admin")]
    public class QuanlysinhvienController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
