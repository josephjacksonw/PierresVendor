using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vendor.Models;
using System.Collections.Generic;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class DistributorTests : IDisposable
  {

    public void Dispose()
    {
      Distributor.ClearAll();
    }

    [TestMethod]
    public void DistributorConstructor_CreatesInstanceOfDistributor_Distributor()
    {
      Distributor newDistributor = new Distributor("distributor name", "distrubutor description");
      Assert.AreEqual(typeof(Distributor), newDistributor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "distributor name";
      string description = "distributor discription";
      Distributor newDistributor = new Distributor(name, description);

      //Act
      string result = newDistributor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsDistributorId_Int()
    {
      //Arrange
      string name = "Test Distributor";
      string description = "distributor discription";
      Distributor newDistributor = new Distributor(name, description);

      //Act
      int result = newDistributor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithDistributor_OrderList()
    {
      //Arrange
      string orderDescription = "order description.";
      string orderName = "order Name";
      Order newOrder = new Order(orderName, orderDescription, 1, 1);
      List<Order> newList = new List<Order> { newOrder };
      string name = "Work";
      string distDescription = "distributor discription";
      Distributor newDistributor = new Distributor(name, distDescription);
      newDistributor.AddOrder(newOrder);

      //Act
      List<Order> result = newDistributor.Orders;

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }


  }
}