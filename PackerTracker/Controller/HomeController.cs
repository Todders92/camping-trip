using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PackerTracker.Models;

namespace PackerTracker.Controllers
{
  // We tell .NET that HomeController should inherit or extend functionality from ASP.NET Core's built-in Controller class that we import with our using statement
  public class HomeController : Controller
  {
    // This is a route!
   
    [HttpGet("/")]
    public ActionResult Index() 
    { 
       List<CampingItem> allItems = CampingItem.GetAll();
      return View(allItems);
    }

    [HttpGet("/campingitem/new")]
    public ActionResult New() 
    { 
     
      return View(); 
    }

    [HttpPost("/")]
    public ActionResult Create(string item, string price, string weight, string name)
    {
      CampingItem campingItem = new CampingItem(item, price, weight, name);
      return RedirectToAction("Index");
    }

    [HttpPost("/campingitem/delete")]
    public ActionResult DeleteAll()
    {
      CampingItem.ClearAll();
      return RedirectToAction("Index");
    }

    [HttpGet("/campingitem/{id}")]
    public ActionResult Detail(int id)
    {
      CampingItem currentItem = CampingItem.Find(id);
      return View(currentItem);
    }

  }
}