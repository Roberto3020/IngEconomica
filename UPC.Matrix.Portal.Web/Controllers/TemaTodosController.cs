using Microsoft.AspNetCore.Mvc;

namespace UPC.Matrix.Portal.Web.Controllers
{
    public class TemaTodosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
