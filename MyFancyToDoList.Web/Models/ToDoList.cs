using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyFancyToDoList.Web.Models
{
    public class ToDoList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }



    }

    public class ToDoListDbContext : DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
    }

}