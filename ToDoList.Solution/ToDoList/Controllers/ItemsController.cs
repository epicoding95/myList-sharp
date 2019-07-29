using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using System.Collections.Generic;

namespace ToDoList.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
    List<Item> allItems = Item.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string description)


      /// we are telling the view() method to return the "index" view. we have to do this because we are no longer routing a view wth the same exact name as our route method.

      // the second argument specifies what the model property on the view should be
    {
      Item myItem = new Item(description);
      return RedirectToAction("Index");
    }

  }
}
