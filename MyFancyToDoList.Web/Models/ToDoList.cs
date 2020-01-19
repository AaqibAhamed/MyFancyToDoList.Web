using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public bool IsCompleted { get; set; }

        [Display(Name = " Repeating Task ") ]
        public bool IsReOccuring { get; set; }

     
    }

    public class ToDoListDbContext : DbContext
    {
        public DbSet<ToDoList> ToDoLists { get; set; }
    }

}