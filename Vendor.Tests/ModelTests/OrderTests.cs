using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vendor.Models;

namespace Vendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("name", "description", 1, 1);
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }

    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      // Arrange
      string name = "order name";
      string description = "order description";
      Order newOrder = new Order(name, description, 1, 1);
      // Act
      string result = newOrder.Description;
      // Assert
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      //Arrange
      string name = "order name";
      string description = "order description";
      Order newOrder = new Order(name, description, 1, 1);
      //Act
      string updatedDescription = "I am the updated description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      //Assert
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> {};
      // Act
      List<Order> result = Order.GetAll();
      
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string name1 = "name1";
      string name2 = "name2";
      string description01 = "Walk the dog";
      string description02 = "Wash the dishes";
      Order newOrder1 = new Order(name1, description01, 1, 1);
      Order newOrder2 = new Order(name2, description02, 2, 2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      //Act
      List<Order> result = Order.GetAll();
      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string name = "name";
      string description = "walk the dog.";
      Order newOrder = new Order(name, description, 1, 1);
      //Act
      int result = newOrder.Id;
      //Assert
      Assert.AreEqual(1, result);
    }
      [TestMethod]
    public void Find_ReturnsCorrectOrder_Order()
    {
      //Arrange
      string name1 = "name1";
      string name2 = "name2";
      string description01 = "walk the dog.";
      string description02 = "wash the dishes";
      Order newOrder = new Order(name1, description01, 1, 1);
      Order newOrder2 = new Order(name2, description02, 2, 2);
      //Act
      Order result = Order.Find(2);
      //Assert
      Assert.AreEqual(newOrder2, result);
    }

    // [TestMethod]
    // public void Find_ReturnsCorrectArtist_Artist()
    // {
    //   //Arrange
    //   string name01 = "Work";
    //   string name02 = "School";
    //   Artist newArtist1 = new Artist(name01);
    //   Artist newArtist2 = new Artist(name02);

    //   //Act
    //   Artist result = Artist.Find(2);

    //   //Assert
    //   Assert.AreEqual(newArtist2, result);
    // }

  }
}