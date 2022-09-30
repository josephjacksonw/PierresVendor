using Microsoft.AspNetCore.Mvc;

namespace Vendor.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

      // [Route("/bakery_photos")]
      // public ActionResult FavoritePhotos()
      // {
      //   return View();
      // }

    }
}