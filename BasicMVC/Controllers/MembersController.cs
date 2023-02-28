using Microsoft.AspNetCore.Mvc;

namespace BasicMVC.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
