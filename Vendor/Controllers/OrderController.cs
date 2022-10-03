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


  }
}