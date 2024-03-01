using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.NewFolder
{
    //NewFolder
    [Route("Home")]//[Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("Index")]//==[Route("action")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        } 

        [Route("About")]//==[Route("action")]

        public IActionResult About()
        {
            return View();
        }

        [Route("Details/{id?}")]
        public IActionResult Details(int id)
        {
            return Content($"Details View for ID: {id}");
        }

        //[Route("Details/{id?}")]

        //public int  Details(int id)
        //{
        //    return id;
        //}
    }
}
