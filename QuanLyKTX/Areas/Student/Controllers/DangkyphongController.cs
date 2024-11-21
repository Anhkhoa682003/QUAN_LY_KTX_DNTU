using Microsoft.AspNetCore.Mvc;

namespace QuanLyKTX.Areas.Student.Controllers
{
    [Area("Student")]
    public class DangkyphongController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
