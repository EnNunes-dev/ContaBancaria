using Microsoft.AspNetCore.Mvc;

namespace ContaBancaria.Controllers
{
    public class BancoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
