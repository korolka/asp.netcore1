using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Message()
        {
            string text = "Hello world";
            ViewBag.Message = text;
            return View();
        }
    }
}
