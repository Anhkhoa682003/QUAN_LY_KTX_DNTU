using Microsoft.AspNetCore.Mvc;

namespace QuanLyKTX.Controllers
{
    public class ThongbaoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
