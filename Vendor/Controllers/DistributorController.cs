using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using Vendor.Models;

namespace Vendor.Controllers
{
  public class DistributorController : Controller
  { // check for the added variables to the classes (D description -> name, description)
    // (O description, list of songs -> title, description, price, date)

    [HttpGet("/distributors")]
    public ActionResult Index()
    {
      List<Distributor> allDistributors = Distributor.GetAll();
      return View(allDistributors);
    }

    [HttpGet("/distributors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/distributors")]
    public ActionResult Create(string distributorName, string distributorDescription)// I think this gets changed
    {
      Distributor newDistributor = new Distributor(distributorName, distributorDescription);//ye it needs more things to create it
      return RedirectToAction("Index");
    }

    [HttpGet("/distributors/{id}")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Distributor selectedDistributor = Distributor.Find(id);
      List<Order> distributorOrders = selectedDistributor.Orders;
      model.Add("distributor", selectedDistributor);
      model.Add("orders", distributorOrders);
      return View(model);
    }

    // This one creates new Orders within a given distributor, not new distributors:
    // [HttpPost("/distributors/{distributorId}/orders")] // we'll need this for Orders in almbumsController.cs for songs
    // public ActionResult Create(int distributorId, string orderDescription)//will probably need a lot more data since we have more data inside an order
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Distributor foundDistributor = Distributor.Find(distributorId);
    //   Order newOrder = new Order(orderDescription); // ye this line tells us we def need to add all the new parameters
    //   foundDistributor.AddOrder(newOrder);
    //   List<Order> distributorOrders = foundDistributor.Orders;
    //   List<Song> orderSongs = new List<Song> { };
    //   model.Add("orders", distributorOrders);
    //   model.Add("distributor", foundDistributor);
    //   return View("Show", model);
    // }
    [HttpPost("/distributors/{distributorId}/orders")] //new version of above
    public ActionResult Create (int distributorId, string orderName, string orderDescription, int orderPrice, int orderDays)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Distributor foundDistributor = Distributor.Find(distributorId);
      Order newOrder = new Order(orderName, orderDescription, orderPrice, orderDays);
      foundDistributor.AddOrder(newOrder);
      list<Order> distributorOrders = foundDistributor.Orders;
      model.Add("orders", distributorOrders);
      model.Add("distributor", foundDistributor);
      return View("Show", model);
    }

  }
}