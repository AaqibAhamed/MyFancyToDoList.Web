using MyFancyToDoList.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFancyToDoList.Web.Abstract
{
    public interface IToDoList
    {
        IEnumerable<ToDoList> ToDoLists { get; }



    }
}
