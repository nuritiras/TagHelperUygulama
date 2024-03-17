using Microsoft.AspNetCore.Mvc;

namespace TagHelperUygulama.Controllers
{
    public class KullaniciController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }
    }
}
