using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;

namespace Vendor.Controllers
{
  public class OrdersController : Controller
  {

    [HttpGet("/distributors/{distributorId}/orders/new")]
    public ActionResult New(int distributorId)
    {
      Distributor distributor = Distributor.Find(distributorId);
      return View(distributor);
    }

    [HttpGet("/distributors/{distributorId}/orders/{orderId}")]
    public ActionResult Show(int distributorId, int orderId)
    {
      Order foundOrder = Order.Find(orderId);
      Distributor foundDistributor = Distributor.Find(distributorId);
      Dictionary<string, object> model = new Dictionary<string, object>();
      model.Add("order", foundOrder);
      model.Add("distributor", foundDistributor);
      return View(model);
    }

// I don't think we need any of this below
    // [HttpPost("/distributors/{distributorId}/orders/{orderId}/songs")] // we'll need this for orders in almbumsController.cs for songs
    // public ActionResult Create(int distributorId, int orderId, string songName)
    // {
    //   Dictionary<string, object> model = new Dictionary<string, object>();
    //   Distributor foundDistributor = Distributor.Find(distributorId);
    //   Order foundOrder = Order.Find(orderId);
    //   List<Song> orderSongs = foundOrder.Songs;
    //   Song newSong = new Song(songName);
    //   foundOrder.AddSong(newSong);
    //   model.Add("songs", orderSongs);
    //   model.Add("order", foundOrder);
    //   model.Add("distributor", foundDistributor);
    //   return View("Show", model);
    // }

  }
}