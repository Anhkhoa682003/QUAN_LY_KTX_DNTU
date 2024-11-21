using Microsoft.AspNetCore.Mvc;

namespace QuanLyKTX.Areas.Student.Controllers
{
    [Area("Student")]
    public class DangnhapController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
