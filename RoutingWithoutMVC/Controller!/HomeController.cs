using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.NewFolder
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public int  Details(int id)
        {
            return id;
        }
    }
}
