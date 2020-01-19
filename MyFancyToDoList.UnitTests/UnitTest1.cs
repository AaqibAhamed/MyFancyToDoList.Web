using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
//using MyFancyToDoList.Web.Abstract;
using MyFancyToDoList.Web.Models;

namespace MyFancyToDoList.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CanAddList()
        {
            Mock<IToDoList> mock = new Mock<IToDoList>();
            mock.Setup(t => t).Returns(new ToDoList[]
            {
                new ToDoList{Name ="Task1"},
                new ToDoList{Name="Task2"}

            });
        }
    }
}
