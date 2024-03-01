using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controller_
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
