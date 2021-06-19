using Microsoft.AspNetCore.Mvc;

namespace SweetShop.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        ViewBag.AllSweets = new List<Sweet>(_db.Sweets.OrderBy(sweet => sweet.Name));
        ViewBag.AllFlavors = new List<Flavor>(_db.Flavors.OrderBy(flavor => flavor.Name));
        return View();
      }

    }
}