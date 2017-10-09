using Microsoft.AspNetCore.Mvc;
//using LayoutProject.Models;

namespace LayoutProject.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}
