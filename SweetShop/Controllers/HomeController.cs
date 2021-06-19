using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using SweetShop.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace SweetShop.Controllers

{
  public class HomeController : Controller
  {
    private readonly SweetShopContext _db;

    public HomeController(SweetShopContext db)
    {
      _db = db;
    }


    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.AllTreats = new List<Treat>(_db.Treats.OrderBy(treat => treat.Name));
      ViewBag.AllFlavors = new List<Flavor>(_db.Flavors.OrderBy(flavor => flavor.Name));
      return View();
    }

  }
}