using Microsoft.AspNetCore.Mvc;

namespace Tmb.Api.Controllers
{
    public class TmbController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
