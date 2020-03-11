using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using PackerTracker.Models;

namespace PackerTracker.Tests
{
    [TestClass]
  public class WordCounterTests
  {

    [TestMethod]
    public void Find_FindsItemByIdField_CampingItem()
    {
        //Arrange
        string item = "chair";
        string price = "$3.00";
        string weight = "2 pounds";
        string name = "person";
        CampingItem campingItem = new CampingItem(item, price, weight, name);
        //Act
        CampingItem foundItem = CampingItem.Find(1);
        

        //Assert
        Assert.AreEqual(1, foundItem.Id);
    }
  }

}