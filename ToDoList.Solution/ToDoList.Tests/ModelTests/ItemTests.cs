using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList.Models;
using System.Collections.Generic;
using System;

namespace ToDoList.Tests
{
    [TestClass]
    ////IDisposable is what is reffered to as an interface
    //  : syntax extends functionally from IDisposable  TO our ItemTest class
    public class ItemTest : IDisposable
    {

        public void Dispose()
        {
            Item.ClearAll();
        }

        [TestMethod]
        ////ItemConstructor-- is the method were testing
        ////CreatesInstanceOf--describes the behavior we want in our method
        ////item is the expected return value of the method were testing
        public void ItemConstructor_CreatesInstanceOfItem_Item()
        {
            Item newItem = new Item("test");
            ////typeof-- returns the data type of a class
            ////gettype() returns the data type of a specific object
            Assert.AreEqual(typeof(Item), newItem.GetType());
        }

        [TestMethod]
        public void GetDescription_ReturnsDescription_String()
        {
            ////create a new string called description
            ///create a new item object, passsing the description
            ///Record the result of retrieving the description property of newitem
            /////Last line will confirm the retrieved item object matches the description
            string description = "Walk the dog.";
            Item newItem = new Item(description);

            string updatedDescription = "Do the dishes";
            newItem.Description = updatedDescription;
            string result = newItem.Description;

            Assert.AreEqual(updatedDescription, result);
        }

        [TestMethod]
        public void GetAll_ReturnsItems_ItemList()
        {
            string description01 = "Walk the dog";
            string description02 = "Wash the dishes";
            Item newItem1 = new Item(description01);
            Item newItem2 = new Item(description02);
            List<Item> newList = new List<Item> { newItem1, newItem2 };

            List<Item> result = Item.GetAll();

            CollectionAssert.AreEqual(newList, result);
        }



        [TestMethod]
        public void GetAll_ReturnsEmptyList_ItemsList()
        {
            ///Arrange
            List<Item> newList = new List<Item> { };

            //Act
            List<Item> result = Item.GetAll();

            //Assert
            CollectionAssert.AreEqual(newList, result);
        }


        [TestMethod]
        public void GetId_ItemsInstantiateWithAnIdAndGetterReturns_Int()
        {
            //Arrange
            string description = "Walk the dog.";
            Item newItem = new Item(description);

            //Act
            int result = newItem.Id;

            //Assert
            Assert.AreEqual(1, result);
        }


        [TestMethod]
        public void Find_ReturnsCorrectItem_Item()
        {
            //Arrange
            string description01 = "Walk the dog";
            string description02 = "Wash the dishes";
            Item newItem1 = new Item(description01);
            Item newItem2 = new Item(description02);

            //Act
            Item result = Item.Find(2);

            //Assert
            Assert.AreEqual(newItem2, result);
        }



    }
}