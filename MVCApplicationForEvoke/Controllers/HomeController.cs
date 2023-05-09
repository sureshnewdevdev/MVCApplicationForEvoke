using Microsoft.AspNetCore.Mvc;
using MVCApplicationForEvoke.Models;
using System.Diagnostics;

namespace MVCApplicationForEvoke.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


    //    app.MapControllerRoute(
    //name: "default",
    //pattern: "{controller=Home}/{action=Index}/{id?}");

        public IActionResult Index()
        {
            ViewBag.ValueToView = "This value is for screen content";
            ViewBag.SecondValue = "Hi123456789 all This from controller";
            ViewBag.numbreValue = 100;
            ViewBag.BooleanValue = true;
            return View();
            //return View("Index");
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