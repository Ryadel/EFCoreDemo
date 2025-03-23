using Microsoft.AspNetCore.Mvc;

namespace EFCoreDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => RedirectToAction("Index", "Products");
    }
}
