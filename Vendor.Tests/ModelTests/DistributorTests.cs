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
      Distributor newDistributor = new Distributor("test distributor");
      Assert.AreEqual(typeof(Distributor), newDistributor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Distributor";
      Distributor newDistributor = new Distributor(name);

      //Act
      // string result = newDistributor.Name;
      string result = "good fail";

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsDistributorId_Int()
    {
      //Arrange
      string name = "Test Distributor";
      Distributor newDistributor = new Distributor(name);

      //Act
      // int result = newDistributor.Id;
      int result = 33;

      //Assert
      Assert.AreEqual(1, result);
    }

    // [TestMethod]
    // public void AddAlbum_AssociatesAlbumWithDistributor_AlbumList()
    // {
    //   //Arrange
    //   string description = "Walk the dog.";
    //   Album newAlbum = new Album(description);
    //   List<Album> newList = new List<Album> { newAlbum };
    //   string name = "Work";
    //   Distributor newDistributor = new Distributor(name);
    //   newDistributor.AddAlbum(newAlbum);

    //   //Act
    //   List<Album> result = newDistributor.Albums;

    //   //Assert
    //   CollectionAssert.AreEqual(newList, result);
    // }


  }
}