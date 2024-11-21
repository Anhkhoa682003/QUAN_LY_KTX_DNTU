using Microsoft.AspNetCore.Mvc;

namespace QuanLyKTX.Areas.Student.Controllers
{
    [Area("Student")]
    public class LienheController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
