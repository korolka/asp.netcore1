using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class ListController : Controller
    {
        public IActionResult Info()
        {
            return View();
        }
    }
}
