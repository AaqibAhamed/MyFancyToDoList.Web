using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MyFancyToDoList.Web.Abstract;
using MyFancyToDoList.Web.Controllers;
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
            mock.Setup(t => t.ToDoLists).Returns(new ToDoList[]
            {
                new ToDoList{Id=1, Name ="Task1",IsCompleted=true},
                new ToDoList{Id=2, Name="Task2",IsReOccuring =false}

            }) ;


            //mock.object
          
        }

      
    }
}
