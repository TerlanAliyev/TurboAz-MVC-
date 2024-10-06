using Microsoft.AspNetCore.Mvc;
using Turboaz.Models;

namespace Turboaz.Controllers
{
    public class HomeController : Controller
    {
        private readonly TurboazContext _sql;

        public HomeController(TurboazContext sql)
        {
            _sql = sql;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
