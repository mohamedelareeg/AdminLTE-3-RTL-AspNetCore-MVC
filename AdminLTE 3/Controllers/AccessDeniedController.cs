using Microsoft.AspNetCore.Mvc;

namespace AdminLTE.Controllers
{
    public class AccessDeniedController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
