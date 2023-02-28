using BasicMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BasicMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //Member m1 = new Member();
            //m1.ID = 100;
            //m1.FullName = "Phubohdee Areesawangkit";
            //m1.Address = "Thailand";

            //Member m2 = new Member();
            //m2.ID = 200;
            //m2.FullName = "Bill";
            //m2.Address = "BKK";

            //Member m3 = new Member();
            //m3.ID = 300;
            //m3.FullName = "Bill Aree";
            //m3.Address = "Nonthaburi";

            //List<Member> MemberLists = new List<Member>();
            //MemberLists.Add(m1);
            //MemberLists.Add(m2);
            //MemberLists.Add(m2);

            //return View(MemberLists);

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(Member model)
        {
            if (ModelState.IsValid)
            {
                return View("Result", model);
            }

            return View(model);
        }

        public IActionResult Faq()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}